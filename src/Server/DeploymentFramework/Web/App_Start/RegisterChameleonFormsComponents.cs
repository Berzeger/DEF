using ChameleonForms.ModelBinders;
using System;
using System.Web.Mvc;

[assembly: WebActivator.PreApplicationStartMethod(typeof(Baud.Deployment.Web.App_Start.RegisterChameleonFormsComponents), "Start")]
 
namespace Baud.Deployment.Web.App_Start
{
    public static class RegisterChameleonFormsComponents
    {
        public static void Start()
        {
            System.Web.Mvc.ModelBinders.Binders.Add(typeof(DateTime), new DateTimeModelBinder());
            System.Web.Mvc.ModelBinders.Binders.Add(typeof(DateTime?), new DateTimeModelBinder());
        }
    }
}