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
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public DateTime BirthTime { get; set; }
        public decimal BirthWeight { get; set; }
        public WeightRecord[] WeightRecords;
        public decimal BirthHeight { get; set; }
        public decimal CurrentHeight { get; set; }
        public decimal BirthHeadCircumference { get; set; }
        public decimal CurrentHeadCircumference { get; set; }
        public string BirthHospital { get; set; }
        public string DoctorName { get; set; }
        public string[] BabyPictures { get; set; }
        public string[] MedicalRecords { get; set; }
        public SleepingTrack SleepingTrack;
        public FeedingTrack FeedingTrack;
        #endregion
        #region Methods


        #endregion
    }
}
