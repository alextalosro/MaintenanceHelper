namespace MaintenanceHelper.Model
{
    public class MajorAlarm
    {
        public uint Index { get; set; }

        public uint AlarmCode { get; set; }

        public uint AlarmData { get; set; }

        public uint AlarmType { get; set; }

        public string AlarmTime { get; set; }

        public string AlarmName { get; set; }

        public string AlarmTask { get; set; }

        public uint AlarmCodeSub { get; set; }

        public uint AlarmDataSub { get; set; }

        public uint AlarmTypeSub { get; set; }

        public string AlarmTimeSub { get; set; }

        public string AlarmNameSub { get; set; }

        public string SubCodeDataAditionalInfo { get; set; }

        public string SubCodeDataCharacterString { get; set; }

        public string SubCodeDataCharacterStringRev { get; set; }

    }
}
