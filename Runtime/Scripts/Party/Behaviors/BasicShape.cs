using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using USD.NET;
using USD.NET.Unity;

namespace Unity.Formats.PartyUSD
{
    public class BasicShape : MonoBehaviour
    {
        public enum eShape
        {
            kBox,
            kSphere
        }

        public eShape shape { get; set; }
    }
}
