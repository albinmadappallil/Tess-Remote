﻿using Tess.Shared.Enums;
using System.Runtime.Serialization;

namespace Tess.Shared.Models.RemoteControlDtos
{
    [DataContract]
    public class MouseMoveDto : BaseDto
    {

        [DataMember(Name = "DtoType")]
        public override BaseDtoType DtoType { get; init; } = BaseDtoType.MouseMove;

        [DataMember(Name = "PercentX")]
        public double PercentX { get; set; }

        [DataMember(Name = "PercentY")]
        public double PercentY { get; set; }
    }
}
