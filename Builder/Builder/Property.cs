using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// خواص العقار وبياناته
    /// </summary>
    public class Property
    {
        public string Address { get; set; }
        /// <summary>
        ///نوع العملية
        ///(ايجار - شراء)
        /// </summary>
        public TransactionType TransactionType { get; set; }
        /// <summary>
        /// نوع العقار
        /// </summary>
        public PropertyType PropertyType { get; set; }
        public int TotalBedrooms { get; set; }
        public double FloarArea { get; set; }
        public decimal Price { get; set; }
        public int TotalBathrooms { get; set; }
        public int TotalStoreys { get; set; }
        public int YearBuilt { get; set; }
        public bool HasSwimingPool { get; set; }
        public bool HasWifi { get; set; }
        public bool HasGym { get; set; }
        public bool HasParking { get; set; }
        public bool HasPlayground { get; set; }
        // طريقة خطأ 

        //public Property(string address, TransactionType transactionType, PropertyType propertyType, int totalBedrooms, double floarArea, decimal price, int totalBathrooms, int totalStoreys, int yearBuilt, bool hasSwimingPool, bool hasWifi, bool hasGym, bool hasParking, bool hasPlayground)
        //{
        //    Address = address;
        //    TransactionType = transactionType;
        //    PropertyType = propertyType;
        //    TotalBedrooms = totalBedrooms;
        //    FloarArea = floarArea;
        //    Price = price;
        //    TotalBathrooms = totalBathrooms;
        //    TotalStoreys = totalStoreys;
        //    YearBuilt = yearBuilt;
        //    HasSwimingPool = hasSwimingPool;
        //    HasWifi = hasWifi;
        //    HasGym = hasGym;
        //    HasParking = hasParking;
        //    HasPlayground = hasPlayground;
        //}
        //public Property(string address, TransactionType transactionType, PropertyType propertyType, decimal price)
        //    : this(address, transactionType, propertyType, 1, 120, price, 1, 12, 2000, false, true, false, false, false)
        //{ }
    }
}
