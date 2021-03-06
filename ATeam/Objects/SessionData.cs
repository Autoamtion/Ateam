﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATeam.Objects
{
    using System.ComponentModel;

    using ATeam.Helpers;
    using ATeam.Objects.Enumerators;

    public class SessionData
    {
        public SessionData()
        {
            ObjectHelper.SetDefaultValues(this);
            var rand = new Random();
            this.SessionDate = DateTime.Now.AddDays(rand.Next(1,30)).AddHours(rand.Next(1, 12));
            this.ProposedSessionDate = this.SessionDate;
            this.Address = RandomDataHelper.GetRandomString(5);
            this.City = RandomDataHelper.GetRandomString(8);
            this.PostCode = string.Format("0{0}-{1}", RandomDataHelper.GetRandomNumber(1), RandomDataHelper.GetRandomNumber(3));
            this.Comment = string.Format("A-Team {0}", DateTime.Now);
        }

        public DateTime ProposedSessionDate { get; set; }

        public DateTime SessionDate { get; set; }

        [DefaultValue(true)]
        public bool SetSpecificLocation { get; set; }

        public string PostCode { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public string Comment { get; set; }

        [DefaultValue(true)]
        public bool IsSpacePerSession { get; set; }

        [DefaultValue(5)]
        public int PlaceForSession { get; set; }

        [DefaultValue(true)]
        public bool LevelBase { get; set; }

        [DefaultValue(true)]
        public bool LevelAdvanced { get; set; }

        [DefaultValue(true)]
        public bool LevelExpert { get; set; }

        [DefaultValue(true)]
        public bool LevelOther { get; set; }

        [DefaultValue(true)]
        public bool IstqbFoundationLevelEnglishPolish { get; set; }

        [DefaultValue(true)]
        public bool ReqbFoundationLevelEnglishPolish { get; set; }

        [DefaultValue(true)]
        public bool IstqbAdvancedLevelTestManagerEnglishPolish { get; set; }

        [DefaultValue(true)]
        public bool IstqbAdvancedLevelTestAnalystEnglishPolish { get; set; }

        [DefaultValue(true)]
        public bool IstqbAdvancedLevelTechnicalTestAnalystEnglishPolish { get; set; }

        [DefaultValue(true)]
        public bool IstqbAgileTesterExtensionEnglishPolish { get; set; }

        [DefaultValue(true)]
        public bool IstqbTestManagementEnglish { get; set; }

        [DefaultValue(true)]
        public bool IstqbImprovingTheTestProcessEnglish { get; set; }

        [DefaultValue(Examiner.ATeam1)]
        public Examiner ExaminerId { get; set; }

        [DefaultValue(5)]
        public int IstqbAdvancedLevelTestManagerPlaces { get; set; }

        [DefaultValue(5)]
        public int IstqbAdvancedLevelTestAnalystPlaces { get; set; }

        [DefaultValue(5)]
        public int IstqbAdvancedLevelTechnicalTestAnalystPlaces { get; set; }

        [DefaultValue(5)]
        public int IstqbFoundationLevelPlaces { get; set; }

        [DefaultValue(5)]
        public int ReqbFoundationLevelPlaces { get; set; }

        [DefaultValue(5)]
        public int IstqbTestManagementPlaces { get; set; }

        [DefaultValue(5)]
        public int IstqbImprovingTheTestProcessPlaces { get; set; }

        [DefaultValue(5)]
        public int IstqbAgileTesterExtensionPlaces { get; set; }

        [DefaultValue(false)]
        public bool FillComment { get; set; }
    }
}
