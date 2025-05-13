using System;


using System.IO;

namespace FileFinderExample
{
    class DriveInfoItem
    {
        public string DriveName { get; set; }
        public string DriveVolumeLabel { get; set; }
        public string DriveFormat { get; set; }
        public string DriveTypeString { get; set; }
        public long TotalFreeSpaceGb { get; set; }
        public long TotalSizeGb { get; set; }
        public long AvailableFreeSpaceGb { get; set; }

        public DriveInfoItem(DriveInfo driveInfo)
        {
            if (driveInfo == null)
                throw new ArgumentNullException("driveInfo", "Параметр не может быть null!");

            DriveName = driveInfo.Name;
            DriveVolumeLabel = driveInfo.VolumeLabel;
            DriveFormat = driveInfo.DriveFormat;
            DriveTypeString = GetDriveTypeAsString(driveInfo.DriveType);

            TotalFreeSpaceGb = GetSizeInGigabytes(driveInfo.TotalFreeSpace);
            TotalSizeGb = GetSizeInGigabytes(driveInfo.TotalSize);
            AvailableFreeSpaceGb = GetSizeInGigabytes(driveInfo.AvailableFreeSpace);
        }

        private long GetSizeInGigabytes(long size)
        {
            return size / 1_073_741_824;
        }

        private string GetDriveTypeAsString(DriveType driveType)
        {
            switch (driveType)
            {
                case DriveType.Fixed:
                    return "Фиксированный диск";
                case DriveType.Network:
                    return "Сетевой диск";
                case DriveType.Removable:
                    return "Съёмный диск";
                case DriveType.Ram:
                    return "ОЗУ";
                case DriveType.NoRootDirectory:
                    return "Без корневого каталога";
                case DriveType.CDRom:
                    return "CD-ROM";
                default:
                    return "Неизвестно";
            }
        }

        public override string ToString()
        {
            string readableName = string.IsNullOrEmpty(DriveVolumeLabel)
                ? $"[{DriveName}]"
                : $"[{DriveVolumeLabel}] {DriveName}";

            return $"{readableName}. {DriveTypeString}, {DriveFormat}, Объём: {TotalSizeGb} Гб, " +
                   $"Свободно: {TotalFreeSpaceGb} Гб";
        }
    }
}

