using System;
using System.Collections.Generic;
using System.Text;
using TaskThree.BLL.DTO;

namespace TaskThree.BLL.Interfaces
{
    public interface IRestaurantService
    {
        IEnumerable<RestaurantDTO> GetByPostalCode(string code);
    }
}
