using ApplicationService.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary
{
    [ServiceContract]
    public interface IPaint
    {
        [OperationContract]
        string Message();

        [OperationContract]
        List<PaintDTO> GetPaints();

        [OperationContract]
        List<PaintDTO> GetAvailablePaints();

        [OperationContract]
        PaintDTO GetPaintByID(int id);

        [OperationContract]
        PaintDTO GetAvailablePaintByID(int id);

        [OperationContract]
        string PostPaint(PaintDTO paintDTO);

        [OperationContract]
        string DeletePaint(int id);

        [OperationContract]
        string MakePaintUnavailable(int id);
    }
}
