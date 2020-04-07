namespace App
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class registros
    {
        public int id { get; set; }

        public string area { get; set; }

        public string celula { get; set; }

        public string unidade { get; set; }

        public string cargo { get; set; }

        public string superior { get; set; }

        public string descSumaria { get; set; }

        public string responsabilidadesEspecificas { get; set; }

        public string responsabilidadesAlemTodos { get; set; }

        public string competenciasObrigatorias { get; set; }

        public string competenciasDesejaveis { get; set; }

        public string experienciaDesejavel { get; set; }

        public string cp1 { get; set; }

        public string cp2 { get; set; }

        public string nivelObrigatorio { get; set; }

        public string nivelDesejavel { get; set; }

        public string areaConhecimentoDesejavel { get; set; }

        public string areaConhecimentoObrigatorio { get; set; }

        public string nv1 { get; set; }

        public string nv2 { get; set; }

        public string nv3 { get; set; }

        public string nv4 { get; set; }

        public string nv5 { get; set; }

        public int? int1 { get; set; }

        public int? int2 { get; set; }

        public int? int3 { get; set; }

        public int? int4 { get; set; }

        public int? int5 { get; set; }



        public registros(String area,string celula,string unidade,string cargo,string superior, string descSumaria,string responsabilidadesEspecificas,string responsabilidadesAlemTodos,string competenciasObrigatorias,
            
            string competenciasDesejaveis, string experienciaDesejavel,string cp1,string cp2,string nivelObrigatorio, string nivelDesejavel, string areaConhecimentoDesejavel, string areaConhecimentoObrigatorio)
    {


            this.area = area;
            this.celula = celula;
            this.unidade = unidade;
            this.cargo = cargo;
            this.superior = superior;
            this.descSumaria = descSumaria;
            this.responsabilidadesEspecificas = responsabilidadesEspecificas;
            this.responsabilidadesAlemTodos = responsabilidadesAlemTodos;
            this.competenciasObrigatorias = competenciasObrigatorias;
            this.competenciasDesejaveis = competenciasDesejaveis;
            this.experienciaDesejavel = experienciaDesejavel;
            this.cp1 = cp1;
            this.cp2 = cp2;
            this.nivelObrigatorio = nivelObrigatorio;
            this.nivelDesejavel = nivelDesejavel;
            this.areaConhecimentoDesejavel = areaConhecimentoDesejavel;
            this.areaConhecimentoObrigatorio = areaConhecimentoObrigatorio;


     



      


    }

        public registros()
        {


        }


}


  
    
}
