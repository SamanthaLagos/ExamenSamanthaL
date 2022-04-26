using Examen3_JennyLagos.Interfaces;
using Microsoft.AspNetCore.Components;
using Modelos;

namespace Examen3_JennyLagos.Pages.Usuarios
{
    partial class Usuarios
    {
        [Inject] private IUsuarioServicio _usuarioServicio { get; set; }

        private IEnumerable<Usuario> usuariosLista { get; set; }

        protected override async Task OnInitializedAsync()
        {
            usuariosLista = await _usuarioServicio.GetLista();
        }

    }
}
