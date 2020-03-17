using MetroDevABM.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetroDevABM.Web.Models
{
    public class RepoCatalogModel
    {
        private List<SelectListItem> Empty { get; set; }
        private Dictionary<string, List<SelectListItem>> Listas { get; set; }
        private MetroDevABMDbContext db { get; set; }
        private object[] Parametros { get; set; }

        public RepoCatalogModel Filtro(params object[] _Parametros)
        {
            if (_Parametros.Count() > 0)
            {
                Parametros = _Parametros;
            }
            return this;
        }


        public RepoCatalogModel()
        {
            db = new MetroDevABMDbContext();
            Empty = new List<SelectListItem>();
            Listas = new Dictionary<string, List<SelectListItem>>();
        }

        public RepoCatalogModel(MetroDevABMDbContext _db)
        {
            db = _db;
            Empty = new List<SelectListItem>();
            Listas = new Dictionary<string, List<SelectListItem>>();
        }

        public List<SelectListItem> GetList(string nombre)
        {
            if (Listas.ContainsKey(nombre))
            {
                return Listas[nombre];
            }
            AddToList(nombre);
            return Listas[nombre];
        }

        public SelectList GetSelectList(string nombre, object Value)
        {
            var list = GetList(nombre);
            return new SelectList(list, "Value", "Text", Value);
        }

        private void AddToList(string nombre)
        {
            if (Listas.ContainsKey(nombre))
            {
                Listas.Remove(nombre);
            }
            var l = new List<SelectListItem>();
            switch (nombre)
            {
                case "ClientType":
                    l = db.ClientTypes.ToList()
                        .Select(s => new SelectListItem { Text = s.Title, Value = s.Id.ToString() })
                        .ToList();
                    break;
                case "Gender":
                    l = db.Genders.ToList()
                        .Select(s => new SelectListItem { Text = s.Title, Value = s.Id.ToString() })
                        .ToList();
                    break;
            }
            Listas.Add(nombre, l);
            Parametros = null;
        }

        public string GetSelected(string Nombre, object Valor)
        {
            var l = GetList(Nombre);
            if (Valor != null)
            {
                if (l.Any(a => a.Value == Valor.ToString()))
                {
                    return l.First(f => f.Value == Valor.ToString()).Text;
                }
            }
            return "";
        }
    }
}