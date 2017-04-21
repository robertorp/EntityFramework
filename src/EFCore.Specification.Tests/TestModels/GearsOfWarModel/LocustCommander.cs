using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.EntityFrameworkCore.Specification.Tests.TestModels.GearsOfWarModel
{
    public class LocustCommander : LocustLeader
    {
        public LocustHorde CommandingFaction { get; set; }

        public string DefeatedByNickname { get; set; }
        public int? DefeatedBySquadId { get; set; }
        public Gear DefeatedBy { get; set; }
    }
}
