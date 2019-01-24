﻿using System;
namespace FrameworkEPL.Entities
{
    public class LockDoorInfo
    {
        public string   NameSchool   { get; set; }
        public string   BuildName    { get; set; }
        public string   FloordName   { get; set; }
        public string   BlockdName   { get; set; }
        public string   LockerName   { get; set; }
        public string   DoorName     { get; set; }
        public string   Status       { get; set; }
        public int      IdLock       { get; set; }
        public string   NumberLock   { get; set; }
        public string   Password     { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
