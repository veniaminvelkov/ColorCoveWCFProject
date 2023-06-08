using ApplicationService.DTOs;
using Data.Entities;
using Repository.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Implementations
{
    public class PaintManagementService
    {
        /*
    -ID <int>
	-Paint type: <int>
		-Default (Unspecified) [0]
		-Oil paint [1]
		-Acrylic paint [2]
		-Watercolor paint [3]
		-Gouache [4]
		-Error [-1 or any other number]
	-Brand <string>
	-Price <double>
	-Aditional info <string>
	-Is available <bool>
	-Expiry date <DateTime>
         */
        public List<PaintDTO> Get()
        {
            List<PaintDTO> paintDTO = new List<PaintDTO>();

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                foreach (var item in unitOfWork.PaintRepository.Get())
                {
                    paintDTO.Add(new PaintDTO
                    {
                        Id = item.Id,
                        Brand = item.Brand,
                        ExpiryDate = item.ExpiryDate,
                        IsAvailable = item.IsAvailable,
                        PaintType = item.PaintType,
                        Price = item.Price,
                        Quantity = item.Quantity
                    });
                }
            }
            return paintDTO;
        }
        public List<PaintDTO> GetAvailable()
        {
            List<PaintDTO> paintDTO = new List<PaintDTO>();

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                foreach (var item in unitOfWork.PaintRepository.Get())
                {
                    if (item.IsAvailable == true && item.Quantity > 0)
                    {
                        paintDTO.Add(new PaintDTO
                        {
                            Id = item.Id,
                            Brand = item.Brand,
                            ExpiryDate= item.ExpiryDate,
                            IsAvailable = true,
                            PaintType= item.PaintType,
                            Price= item.Price,
                            Quantity = item.Quantity
                        });
                    }
                }
            }
            return paintDTO;
        }
        public PaintDTO GetById(int id)
        {
            PaintDTO paintDTO = new PaintDTO();

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                Paint paint = unitOfWork.PaintRepository.GetByID(id);
                if (paint != null)
                {
                    paintDTO = new PaintDTO
                    {
                        Id = paint.Id,
                        Brand = paint.Brand,
                        ExpiryDate = paint.ExpiryDate,
                        IsAvailable = paint.IsAvailable,
                        PaintType = paint.PaintType,
                        Price = paint.Price,
                        Quantity = paint.Quantity
                    };
                }
            }
            return paintDTO;
        }
        public PaintDTO GetOnlyAvailableById(int id)
        {
            PaintDTO paintDTO = new PaintDTO();

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                Paint paint = unitOfWork.PaintRepository.GetByID(id);
                if (paint != null && paint.IsAvailable == true)
                {
                    paintDTO = new PaintDTO
                    {
                        Id = paint.Id,
                        Brand = paint.Brand,
                        ExpiryDate = paint.ExpiryDate,
                        IsAvailable = paint.IsAvailable,
                        PaintType = paint.PaintType,
                        Price = paint.Price,
                        Quantity = paint.Quantity
                    };
                }
            }
            return paintDTO;
        }
        public bool Save(PaintDTO paintDTO)
        {
            Paint paint = new Paint
            {
                Id = paintDTO.Id,
                Brand = paintDTO.Brand,
                ExpiryDate = DateTime.Now.AddMonths(paintDTO.ExpiryDate.Month * paintDTO.ExpiryDate.Second / 100).AddYears(paintDTO.ExpiryDate.Second / paintDTO.ExpiryDate.Month),
                IsAvailable = paintDTO.IsAvailable,
                PaintType = paintDTO.PaintType,
                Price = paintDTO.Price,
                Quantity = paintDTO.Quantity
            };

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                /*
                 * Result expected: item gets deleted and saved in the same id
                 * Actual result: Item gets saved in the next unused id
                 * 
                if (unitOfWork.PaintRepository.GetByID(paint.Id) != null)
                {
                    unitOfWork.PaintRepository.Delete(paint.Id);
                }
                */
                unitOfWork.PaintRepository.Delete(paint.Id);
                unitOfWork.PaintRepository.Insert(paint);
                unitOfWork.Save();
            }
            return true;
        }
        public bool Delete(int id)
        {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    Paint paint = unitOfWork.PaintRepository.GetByID(id);
                    unitOfWork.PaintRepository.Delete(paint);
                    unitOfWork.Save();
                }
                return true;
        }
        public bool MakeUnavailable(int id)
        {

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                Paint paint = unitOfWork.PaintRepository.GetByID(id);
                paint.IsAvailable = false;
                unitOfWork.Save();
            }

            return true;
        }
    }
}
