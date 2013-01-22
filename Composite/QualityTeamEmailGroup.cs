using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Composite.Interface;
namespace Composite
{
    public class QualityTeamEmailGroup: IEmail
    {
        public List<IEmail> qualityTeamEmailGroup;

        public QualityTeamEmailGroup()
        {
            qualityTeamEmailGroup = new List<IEmail>();
        }

        public void Send()
        {
            foreach (var email in qualityTeamEmailGroup)
            {
                email.Send();
            }
        }
    }

}
