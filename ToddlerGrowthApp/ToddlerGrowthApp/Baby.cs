using System;
namespace ToddlerGrowthApp
{
    /// <summary>
    /// this class represent the baby who is growt rate will be trak
    /// </summary>
    enum SexOfBaby
    {
        Female,
        Male
    }
    class Baby
    {
       
        #region Properties
        public string BabyName { get; set; }
        public SexOfBaby BabySex { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public DateTime BirthTime { get; set; }
        public decimal BirthWeight { get; set; }
        public GrowthRate WeightRecords { get; set; }
        public decimal BirthHeight { get; set; }
        public GrowthRate HeightRecords { get; set; }
        public decimal BirthHeadCircumference { get; set; }
        public GrowthRate HeadCircumferenceRecords { get; set; }
        public string BirthHospital { get; set; }
        public string DoctorName { get; set; }
        public string  BabyPictures { get; set; }
        public string MedicalRecords { get; set; }
        public SleepingTrack SleepingTrack { get; set; }
        public FeedingTrack FeedingTrack { get; set; }
        public decimal Bmi { get; set;}
        #endregion
        #region Methods
        ///this methods will calculate baby's bmi and return value
        /// return value will like underweight,normal weight,overweight,Obese
        /// child must be between 2 years to 20 years old.

        #endregion
    }
}
