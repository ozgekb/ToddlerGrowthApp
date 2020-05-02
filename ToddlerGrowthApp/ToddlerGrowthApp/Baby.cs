using System;
namespace ToddlerGrowthApp
{
    /// <summary>
    /// this class represent the baby who is growt rate will be trak
    /// </summary>
    class Baby
    {
        #region Properties
        public string BabyName { get; set; }
        public Enum BabySex;
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public DateTime BirthTime { get; set; }
        public decimal BirthWeight { get; set; }
        public GrowthRate[] WeightRecords;
        public decimal BirthHeight { get; set; }
        public GrowthRate[] HeightRecords;
        public decimal BirthHeadCircumference { get; set; }
        public GrowthRate[] HeadCircumferenceRecords;
        public string BirthHospital { get; set; }
        public string DoctorName { get; set; }
        public string[] BabyPictures { get; set; }
        public string[] MedicalRecords { get; set; }
        public SleepingTrack SleepingTrack;
        public FeedingTrack FeedingTrack;
        public decimal Bmi { get; set;}
        #endregion
        #region Methods
        ///this methods will calculate baby's bmi and return value
        /// return value will like underweight,normal weight,overweight,Obese
        /// child must be between 2 years to 20 years old.

        #endregion
    }
}
