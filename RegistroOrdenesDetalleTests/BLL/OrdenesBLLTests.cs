using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegistroOrdenesDetalle.BLL;
using RegistroOrdenesDetalle.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegistroOrdenesDetalle.BLL.Tests
{
    [TestClass()]
    public class OrdenesBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            

            bool paso;
            Ordenes ordenes = new Ordenes();

            ordenes.OrdenId = 0;
            ordenes.Fecha = DateTime.Now;
            ordenes.SuplidorId = 1;
            ordenes.Monto = 500;

            ordenes.OrdenesDetalle.Add(new OrdenesDetalle
            {
                Id = 0,
                OrdenId = ordenes.OrdenId,
                ProductoId = 1,
                Cantidad = 1000,
                Costo = 25
            });

            paso = OrdenesBLL.Guardar(ordenes);
            Assert.AreEqual(paso, true);
            
        }

        [TestMethod()]
        public void ExisteTest()
        {
            var paso = OrdenesBLL.Existe(1);
            Assert.IsNotNull(paso);
        }



        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = OrdenesBLL.Eliminar(1);
            Assert.IsNotNull(paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            var paso = OrdenesBLL.Buscar(1);
            Assert.AreEqual(paso, paso);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var lista = new List<Ordenes>();
            lista = OrdenesBLL.GetList(p => true);
            Assert.IsNotNull(lista);
        }


    }
}