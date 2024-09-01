using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class PropertyBuilder
    {
        private Property _Property = new ();
        public PropertyBuilder SetAddress(string address)
        {
            this._Property.Address = address;
            return this;
        }
        public PropertyBuilder SetTransactionType(TransactionType Transactiontype)
        {
            this._Property.TransactionType = Transactiontype;
            return this;
        }
        public PropertyBuilder SetPropertyType(PropertyType propertyType)
        {
            this._Property.PropertyType = propertyType;
            return this;
        }
        public PropertyBuilder SetBedRooms(int BedRooms)
        {
            this._Property.TotalBedrooms = BedRooms;
            return this;
        }
        public PropertyBuilder SetTotalBathroom(int BathRooms)
        {
            this._Property.TotalBathrooms = BathRooms;
            return this;
        }
        public PropertyBuilder SetTotalStoreys(int TotalStoreys)
        {
            this._Property.TotalStoreys = TotalStoreys;
            return this;
        }
        public PropertyBuilder SetYearBuilt(int YearBuilt)
        {
            this._Property.YearBuilt = YearBuilt;
            return this;
        }
        public PropertyBuilder SetFloorArea(double FloarArea)
        {
            this._Property.FloarArea = FloarArea;
            return this;
        }
        public PropertyBuilder SetPrice(decimal price)
        {
            this._Property.Price = price;
            return this;
        }
        public PropertyBuilder HasSwimingPool(bool HasSwimingPool)
        {
            this._Property.HasSwimingPool = HasSwimingPool;
            return this;
        }
        
        public PropertyBuilder HasWifi(bool HasWifi)
        {
            this._Property.HasWifi = HasWifi;
            return this;
        }
        public PropertyBuilder HasGym(bool HasGym)
        {
            this._Property.HasGym = HasGym;
            return this;
        }
        public PropertyBuilder HasParking(bool HasParking)
        {
            this._Property.HasParking = HasParking;
            return this;
        }
        public PropertyBuilder HasPlayground(bool HasPlayground)
        {
            this._Property.HasPlayground = HasPlayground;
            return this;
        }

        //للكلاس دا create  اتحكم من خلالها ان لو مثلا محطش سعر للمنزل معملش  Method  ممكن كمان اعمل 

        private bool CanCreate() => !string.IsNullOrWhiteSpace(_Property.Address) && _Property.Price > 0;

        public PropertyBuilder Reset()
        {
            _Property = new();
            return this;
        }
        public Property Build()
        {
            if(!CanCreate())
            {
                throw new InvalidOperationException("Property Address can not be null and price must be more than Zero");
            }
            // دي الفايدة منها اني امنع اي تصادم للداتا مع بعض ف حالة لو عندي اكتر من واحد استخدم الكلاس دا 
            var BuildProperty = _Property;
            this.Reset();
            return BuildProperty;
        }
    }
}
