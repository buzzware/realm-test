using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Realms;
using NUnit.Framework;

namespace RealmTest.Droid.Tests {
	[TestFixture]
	public class RealmTests {

		public T getLocal<T>(long aId) where T : RealmObject {
			var realm = Realms.Realm.GetInstance();
			var i = aId;
			try {
				return realm.All<Address>().Where(p => p.id == i).ToList().FirstOrDefault() as T;
			} catch (InvalidOperationException e) {
				return null;
			}
			throw new NotImplementedException("T not yet implemented");
		}

		[Test]
		public void LoadRecordTest() {
			var realm = Realms.Realm.GetInstance();
			var address1 = new Address() {
				id = 1,
				kind = "home",
				street = "1 Sesame St",
				city = "Cartoon Fields"
			};
			realm.Write(() => realm.Manage(address1));
			Assert.That(address1.id, Is.Not.EqualTo(0));
			Address loadedAddress = getLocal<Address>(address1.id);
			Assert.That(loadedAddress, Is.Not.Null);
			Assert.That(loadedAddress.street, Is.EqualTo(address1.street));
			Assert.That(loadedAddress.id, Is.EqualTo(address1.id));
		}
	}
}

