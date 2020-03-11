using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using MVCPlantilla.Utilerias;

namespace MvcPlantilla.Controllers
{
    public class VideoController : Controller
    {
        //
        // GET: /Video/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Agregar()
        {
            return View();
        }
        public ActionResult Eliminar()
        {
            return View();
        }
        public ActionResult Modificar()
        {
            return View();
        }
        public ActionResult Ver()
        {
            ViewData["datavideo"] = BaseHelper.ejecutarConsulta("select * from Video", CommandType.Text);
            return View();
        }
        //POST Procesa los datos ingresados al formulario
        [HttpPost]
        public ActionResult Create(int idVideo,
            string titulo,
            int repro,
            string url)
        {
            List<SqlParameter> Parametros = new List<SqlParameter>();
            Parametros.Add(new SqlParameter("@idVideo",idVideo));
            Parametros.Add(new SqlParameter("@nombre",titulo));
            Parametros.Add(new SqlParameter("@repro",repro));
            Parametros.Add(new SqlParameter("@url",url));
            BaseHelper.ejecutarSentencia("INSERT INTO Video VALUES(@idVideo,@nombre,@repro,@url)", CommandType.Text, Parametros);


            return View("Mensaje");

        }

        //POST Elimina los datos ingresados al formulario
        [HttpPost]
        public ActionResult Delete(int idVideo)
        {
            List<SqlParameter> Parametros = new List<SqlParameter>();
            Parametros.Add(new SqlParameter("@idVideo", idVideo));
            BaseHelper.ejecutarSentencia("DELETE FROM Video WHERE idVideo = @idVideo", CommandType.Text, Parametros);
            return View("Mensaje");

        }

        //POST Procesa los datos ingresados al formulario
        [HttpPost]
        public ActionResult Modificar(int idVideo,
            string nombre,
            int repro,
            string url)
        {
            List<SqlParameter> Parametros = new List<SqlParameter>();
            Parametros.Add(new SqlParameter("@idVideo", idVideo));
            Parametros.Add(new SqlParameter("@nombre", nombre));
            Parametros.Add(new SqlParameter("@repro", repro));
            Parametros.Add(new SqlParameter("@url", url));
            BaseHelper.ejecutarSentencia("UPDATE Video SET nombre=@nombre,repro=@repro,url=@url WHERE idVideo=@idVideo", CommandType.Text, Parametros);


            return View("Mensaje");

        }
                
    }
}
