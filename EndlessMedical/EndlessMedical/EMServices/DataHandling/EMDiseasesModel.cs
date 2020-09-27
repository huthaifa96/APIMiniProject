using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessMedical
{

    public class EMDiseasesModel
    {
        public string status { get; set; }
        public Disease[] Diseases { get; set; }
        public Variableimportance[] VariableImportances { get; set; }
    }

    public class Disease
    {
        public string Irritablebowelsyndrome { get; set; }
        public string ChronicleftventricleheartfailureLVHF { get; set; }
        public string Pulmonaryembolus { get; set; }
        public string SuperficialveinthrombosisSVT { get; set; }
        public string AcutehepatitisC { get; set; }
        public string Crohnsdiseasec { get; set; }
        public string Ulcerativecolitisexacerbation { get; set; }
        public string DeepveinthrombosisDVT { get; set; }
        public string Ulcerativecolitis { get; set; }
        public string Perforatedpepticorduodenalulcer { get; set; }
    }

    public class Variableimportance
    {
        public string[][] Irritablebowelsyndrome { get; set; }
        public string[][] ChronicleftventricleheartfailureLVHF { get; set; }
        public string[][] Pulmonaryembolus { get; set; }
        public string[][] SuperficialveinthrombosisSVT { get; set; }
        public string[][] AcutehepatitisC { get; set; }
        public string[][] Crohnsdiseasec { get; set; }
        public string[][] Ulcerativecolitisexacerbation { get; set; }
        public string[][] DeepveinthrombosisDVT { get; set; }
        public string[][] Ulcerativecolitis { get; set; }
        public string[][] Perforatedpepticorduodenalulcer { get; set; }
    }

}
