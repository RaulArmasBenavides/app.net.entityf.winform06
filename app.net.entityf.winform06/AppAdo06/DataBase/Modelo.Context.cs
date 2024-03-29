﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppAdo06.DataBase
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class NeptunoEntities : DbContext
    {
        public NeptunoEntities()
            : base("name=NeptunoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Producto> Productos { get; set; }
    
        public virtual ObjectResult<usp_Categoria_Listar_Result> usp_Categoria_Listar()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_Categoria_Listar_Result>("usp_Categoria_Listar");
        }
    
        public virtual int usp_Producto_Actualizar(string nombre, Nullable<int> idProveedor, Nullable<int> idCategoria, Nullable<decimal> precio, Nullable<short> stock, Nullable<int> idProducto)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var idProveedorParameter = idProveedor.HasValue ?
                new ObjectParameter("IdProveedor", idProveedor) :
                new ObjectParameter("IdProveedor", typeof(int));
    
            var idCategoriaParameter = idCategoria.HasValue ?
                new ObjectParameter("IdCategoria", idCategoria) :
                new ObjectParameter("IdCategoria", typeof(int));
    
            var precioParameter = precio.HasValue ?
                new ObjectParameter("Precio", precio) :
                new ObjectParameter("Precio", typeof(decimal));
    
            var stockParameter = stock.HasValue ?
                new ObjectParameter("Stock", stock) :
                new ObjectParameter("Stock", typeof(short));
    
            var idProductoParameter = idProducto.HasValue ?
                new ObjectParameter("IdProducto", idProducto) :
                new ObjectParameter("IdProducto", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_Producto_Actualizar", nombreParameter, idProveedorParameter, idCategoriaParameter, precioParameter, stockParameter, idProductoParameter);
        }
    
        public virtual int usp_Producto_Adicionar(string nombre, Nullable<int> idProveedor, Nullable<int> idCategoria, Nullable<decimal> precio, Nullable<short> stock, ObjectParameter idProducto)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var idProveedorParameter = idProveedor.HasValue ?
                new ObjectParameter("IdProveedor", idProveedor) :
                new ObjectParameter("IdProveedor", typeof(int));
    
            var idCategoriaParameter = idCategoria.HasValue ?
                new ObjectParameter("IdCategoria", idCategoria) :
                new ObjectParameter("IdCategoria", typeof(int));
    
            var precioParameter = precio.HasValue ?
                new ObjectParameter("Precio", precio) :
                new ObjectParameter("Precio", typeof(decimal));
    
            var stockParameter = stock.HasValue ?
                new ObjectParameter("Stock", stock) :
                new ObjectParameter("Stock", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_Producto_Adicionar", nombreParameter, idProveedorParameter, idCategoriaParameter, precioParameter, stockParameter, idProducto);
        }
    
        public virtual ObjectResult<usp_Producto_Datos_Result> usp_Producto_Datos(Nullable<int> idProducto)
        {
            var idProductoParameter = idProducto.HasValue ?
                new ObjectParameter("IdProducto", idProducto) :
                new ObjectParameter("IdProducto", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_Producto_Datos_Result>("usp_Producto_Datos", idProductoParameter);
        }
    
        public virtual int usp_Producto_Eliminar(Nullable<int> idProducto)
        {
            var idProductoParameter = idProducto.HasValue ?
                new ObjectParameter("IdProducto", idProducto) :
                new ObjectParameter("IdProducto", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_Producto_Eliminar", idProductoParameter);
        }
    
        public virtual ObjectResult<usp_Productos_Datos_Result> usp_Productos_Datos(Nullable<int> idProducto)
        {
            var idProductoParameter = idProducto.HasValue ?
                new ObjectParameter("IdProducto", idProducto) :
                new ObjectParameter("IdProducto", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_Productos_Datos_Result>("usp_Productos_Datos", idProductoParameter);
        }
    
        public virtual ObjectResult<usp_Productos_Listar_Result> usp_Productos_Listar()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_Productos_Listar_Result>("usp_Productos_Listar");
        }
    
        public virtual ObjectResult<usp_Proveedor_Listar_Result> usp_Proveedor_Listar()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_Proveedor_Listar_Result>("usp_Proveedor_Listar");
        }
    }
}
