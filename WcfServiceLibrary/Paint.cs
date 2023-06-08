using ApplicationService.DTOs;
using ApplicationService.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary
{
    public class Paint : IPaint
    {
        private PaintManagementService service = new PaintManagementService();

        public List<PaintDTO> GetPaints()
        {
            return service.Get();
        }

        public List<PaintDTO> GetAvailablePaints()
        {
            return service.GetAvailable();
        }

        public PaintDTO GetPaintByID(int id)
        {
            return service.GetById(id);
        }
        
        public PaintDTO GetAvailablePaintByID(int id)
        {
            return service.GetOnlyAvailableById(id);
        }

        public string PostPaint(PaintDTO paintDTO)
        {
            if (!service.Save(paintDTO))
                return "Paint is not inserted";

            return "Paint is inserted";
        }

        public string DeletePaint(int id)
        {
            if (!service.Delete(id))
                return "Paint is not deleted";

            return "Paint is deleted";
        }

        public string MakePaintUnavailable(int id)
        {
            if (!service.MakeUnavailable(id))
                return "Paint is not made undavailable";

            return "Paint is made undavailable";
        }

        public string Message()
        {
            return "The service is up and running.";
        }
    }
}
