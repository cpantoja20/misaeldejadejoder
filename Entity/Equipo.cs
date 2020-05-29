using System;
using System.Security;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Entity
{

    public class Equipo
    {
        [Key]
        public int EquipoId { get; set; }
        public string NEquipo { get; set; }
        public string Marca { get; set; }
        public double Vrdia  { get; set; }
        

        public void MarcaEquipo()
        {

            if (EquipoId.Equals("Est-100") && NEquipo.Equals("Estacion"))
            {
                Marca = "TopCon";
            }
            else if (EquipoId.Equals("Est-100") && NEquipo.Equals("Estacion"))
            {
                Marca = "Sokkia";
            }
            else if (EquipoId.Equals("Niv-200") && NEquipo.Equals("Nivel"))
            {
                Marca = "TopCon";
            }
            else if (EquipoId.Equals("Niv-200") && NEquipo.Equals("Nivel"))
            {
                Marca = "Sokkia";
            }
            else if (EquipoId.Equals("Teo-300") && NEquipo.Equals("Teodolito"))
            {
                Marca = "TopCon";
            }
            else if (EquipoId.Equals("Teo-300") && NEquipo.Equals("Teodolito"))
            {
                Marca = "Sokkia";
            }
            else if (EquipoId.Equals("GPS-Nav-400") && NEquipo.Equals("GPS Navegador"))
            {
                Marca = "TopCon";
            }
            else if (EquipoId.Equals("GPS-Nav-400") && NEquipo.Equals("GPS Navegador"))
            {
                Marca = "Sokkia";
            }
            else if (EquipoId.Equals("GPS-SubM-500") && NEquipo.Equals("GPS SubMetrico"))
            {
                Marca = "TopCon";
            }
            else if (EquipoId.Equals("GPS-SubM-500") && NEquipo.Equals("GPS SubMetrico"))
            {
                Marca = "Sokkia";
            }
            else if (EquipoId.Equals("RTK-600") && NEquipo.Equals("RTK GPS Doble Frecuencia"))
            {
                Marca = "TopCon";
            }
            else 
            {
                Marca="Sokkia";
            }
        }

        public List<Alquiler> Alquilers { get; } = new List<Alquiler>();
       
    }
}