using LtxApi2020.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LtxApi2020
{
    public class DataEntidades { }
    //{
    //    latamEntities bd = new latamEntities();
    //    public string datocliente(string email)
    //    {
    //        var guidcliente = bd.Entities.Where(x => x.Email == email).FirstOrDefault();
    //        return guidcliente.GUID.ToString();
    //    }
    //    public bool IsEmailExist(string emailID)
    //    {
    //        var v = bd.consignatario.Where(a => a.Email == emailID).FirstOrDefault();
    //        return v != null;
    //    }
    //    public string IsEmailRecoverExist(string emailID)
    //    {
    //        var dato = Guid.Parse(emailID);

    //        var v = bd.PasswordRecovery.Where(a => a.RecoveryKey == dato).FirstOrDefault();
    //        return v.Email;
    //    }
    //    public void guardarConsignatario(consignatario Consigna)
    //    {

    //        bd.consignatario.Add(Consigna);
    //        bd.SaveChanges();
    //    }
    //    public void actualizaPass(consignatario Consigna)
    //    {
    //        var dato = bd.consignatario.Where(x => x.Email == Consigna.Email).FirstOrDefault();
    //        dato.AccessPassword = Consigna.AccessPassword;

    //        bd.SaveChanges();
    //    }
    //    public void guardarRecovery(PasswordRecovery pr)
    //    {
    //        bd.PasswordRecovery.Add(pr);
    //        bd.SaveChanges();
    //    }
    //    public string nombreCiudad(int id)
    //    {

    //        var ciudad = bd.ciudades.Where(x => x.id_ciudad == id).FirstOrDefault();
    //        return ciudad.ciudad.ToString();

    //    }

    //    public List<estados> getEstados()
    //    {
    //        return bd.estados.ToList();
    //    }


    //    public List<WarehouseReceipts> getEmbarques()
    //    {
    //        return bd.WarehouseReceipts.ToList();
    //    }
    //    public List<CiudadesDTO> getCiudades()
    //    {
    //        List<CiudadesDTO> lista = new List<CiudadesDTO>();
    //        var data = bd.ciudades
    //.Join(
    //    bd.estados,
    //    ciudades => ciudades.id_estado,
    //    estados => estados.id_estado,
    //    (ciudades, estados) => new
    //    {
    //        id_ciudad = ciudades.id_ciudad,
    //        ciudad = ciudades.ciudad,
    //        estado = estados.estado
    //    }
    //).ToList();

    //        for (int i = 0; i < data.Count; i++) {
    //            CiudadesDTO cdto = new CiudadesDTO();
    //            cdto.ciudad = data[i].ciudad;
    //            cdto.id_ciudades= data[i].id_ciudad;
    //            cdto.estado = data[i].estado;


    //        lista.Add(cdto);
    //        }




    //        return lista;
    //    }

    //    public string nombreEstado(int id)
    //    {

    //        var estado = bd.estados.Where(x => x.id_estado == id).FirstOrDefault();
    //        return estado.estado.ToString();

    //    }
    //    public consignatario ObtenerUsuario(string email)
    //    {
    //        return bd.consignatario.Where(a => a.Email == email).FirstOrDefault();
    //    }
    //    public consignatario VerificarRegistro(Guid id)
    //    {
    //        var v = bd.consignatario.Where(a => a.ActivationCode == id).FirstOrDefault();
    //        if (v != null)
    //        {
    //            v.isEmailVerified = true;
    //            bd.SaveChanges();



    //        }
    //        return v;
    //    }


    //    //public IEnumerable<WareHouseReciptsViewModel> listaWR()
    //    //{
    //    //    List<WareHouseReciptsViewModel> wrm = new List<WareHouseReciptsViewModel>();
    //    //    var datos = bd.WarehouseReceipts.ToList();
    //    //    for (int i = 0; i < datos.Count; i++)
    //    //    {
    //    //        WareHouseReciptsViewModel wr = new WareHouseReciptsViewModel();

    //    //        wr.GUID = datos[i].GUID;
    //    //        wr.Number = datos[i].Number;
    //    //        wr.TotalPieces = datos[i].TotalPieces;
    //    //        wr.TotalVolume = datos[i].TotalVolume;
    //    //        wr.TotalVolumeWeight = datos[i].TotalVolumeWeight;
    //    //        wr.TotalWeight = datos[i].TotalWeight;
    //    //        wr.CreatedOn = datos[i].CreatedOn;


    //    //        wr.Shipper = "Prueba";

    //    //        wrm.Add(wr);

    //    //    }
    //    //    return wrm;
    //    //}


    //    //public List<AddressViewModel> direccionesUsuario(string email)
    //    //{
    //    //    var dato = (from ent in bd.Entities

    //    //                where ent.Email == email
    //    //                select ent.GUID).FirstOrDefault();


    //    //    var lista = (from add in bd.Address

    //    //                 where add.entityGUID == dato
    //    //                 select new AddressViewModel
    //    //                 {

    //    //                     City = add.city,
    //    //                     Street = add.street,
    //    //                     Country = add.country,
    //    //                     Type = (int)add.addressType,



    //    //                 }).ToList();

    //    //    return lista;
    //    //}
    //    //public EntityViewModel UsuarioSesion(string email)
    //    //{
    //    //    var dato = (from ent in bd.Entities

    //    //                where ent.Email == email
    //    //                select new EntityViewModel
    //    //                {

    //    //                    Name = ent.Name,
    //    //                    Email = ent.Email,
    //    //                    GUID = ent.GUID,
    //    //                    Type = ent.Type,
    //    //                    AccountNumber = ent.AccountNumber,
    //    //                    ParentName = ent.ParentName,
    //    //                    IsPrepaid = ent.IsPrepaid,
    //    //                    MobilePhone = ent.MobilePhone,
    //    //                    Phone = ent.Phone,



    //    //                }).FirstOrDefault();
    //    //    return dato;
    //    //}
    }
