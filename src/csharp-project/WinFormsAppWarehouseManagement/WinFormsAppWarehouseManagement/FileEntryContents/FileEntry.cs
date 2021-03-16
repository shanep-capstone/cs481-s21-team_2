using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppWarehouseManagement.FileEntryContents
{
    class FileEntry
    {
        public string Id { get; set; }

        public string Item_Name { get;set; }

        public string Quantity { get; set; }

        public string Location { get; set; }

        public FileEntry(string id, string item_Name, string quantity, string location)
        {
            Id = id;
            Item_Name = item_Name;
            Quantity = quantity;
            Location = location;
        }
    }
}
