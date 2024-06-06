using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAuto_Client.Service
{
    public static class FileSaveServiceFactory
    {
        public enum FileType
        {
            Excel,
            Word
        }

        public static FileSaveService CreateFileSaveService(FileType fileType)
        {
            switch (fileType)
            {
                case FileType.Excel:
                    return new ExcelSaveService();
                case FileType.Word:
                    return new WordSaveService();
                default:
                    throw new NotSupportedException("File type not supported");
            }
        }
    }
}

