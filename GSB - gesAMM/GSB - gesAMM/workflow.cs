using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB___gesAMM
{
    internal class workflow
    {
        private string wrk_med_depot;
        private string wrk_etp_num;
        private string wrk_dcs_id;
        private string wrk_date;

        public workflow(string leMedDepot, string leEtpNum, string leDcsId, string laDate)
        {
            this.wrk_med_depot = leMedDepot;
            this.wrk_etp_num = leEtpNum;
            this.wrk_dcs_id = leDcsId;
            this.wrk_date = laDate;
        }

        public string getMedDepot() { return this.wrk_med_depot; }
        public string getEtpNum() { return this.wrk_etp_num; }
        public string getDcsId() { return this.wrk_dcs_id; }
        public string getDate() { return this.wrk_date; }
    }
}
