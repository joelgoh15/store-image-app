using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_store_image4.model
{
    public class ClassTableImageData
    {
        #region Fields
        private int _Id;
        private byte[] _ImageData;
        private string _FileName;
        #endregion

        #region Properties
        public int Id { get => _Id; set => _Id = value; }
        public byte[] ImageData { get => _ImageData; set => _ImageData = value; }
        public string FileName { get => _FileName; set => _FileName = value; }

        #endregion

    }
}
