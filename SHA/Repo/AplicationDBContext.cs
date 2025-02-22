using Microsoft.EntityFrameworkCore;
using SHA.Domain.Entity;
using System.Threading;

namespace SHA.Repo
{
    public class AplicationDBContext : DbContext
    {
        public AplicationDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Directorio> Directorios { get; set; }
        public DbSet<Telefono> Telefonos { get; set; }
        public DbSet<LineaTelefono> LineaTelefonos { get; set; }
        public DbSet<LineaCelular> lineaCelulares { get; set; }


        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<EquiposDaniado> EquiposDaniados { get; set; }
        public DbSet<Tablet> Tablets { get; set; }
        public DbSet<Movil> Moviles { get; set; }
        public DbSet<Domain.Entity.Monitor> Monitores { get; set; }
        public DbSet<Computadora> Computadoras { get; set; }
        public DbSet<Laptop> Laptops { get; set; }

        public DbSet<Impresora> Impresoras { get; set; }
        public DbSet<Servidor> Servidores { get; set; }
        public DbSet<Printek> Printeks { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Definir precisión para campos DECIMAL
            modelBuilder.Entity<Computadora>().Property(c => c.Precio).HasPrecision(18, 2);
            modelBuilder.Entity<Laptop>().Property(l => l.Precio).HasPrecision(18, 2);
            modelBuilder.Entity<Domain.Entity.Monitor>().Property(m => m.Precio).HasPrecision(18, 2);
            modelBuilder.Entity<Movil>().Property(m => m.Precio).HasPrecision(18, 2);
            modelBuilder.Entity<Movil>().Property(m => m.PrecioPlan).HasPrecision(18, 2);
            modelBuilder.Entity<Movil>().Property(m => m.Megas).HasPrecision(18, 2);
            modelBuilder.Entity<Tablet>().Property(t => t.Precio).HasPrecision(18, 2);

            // Evitar eliminación en cascada en EquiposDaniados
            modelBuilder.Entity<EquiposDaniado>()
                .HasOne(e => e.Empresa)
                .WithMany(e => e.equiposDaniados)
                .HasForeignKey(e => e.IdEmpresa)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<EquiposDaniado>()
                .HasOne(e => e.Usuario)
                .WithMany(e => e.equiposDaniados)
                .HasForeignKey(e => e.IdUsuario)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<EquiposDaniado>()
                .HasOne(e => e.Departamento)
                .WithMany(e => e.equiposDaniados)
                .HasForeignKey(e => e.IdDepartamento)
                .OnDelete(DeleteBehavior.Restrict);



            //modelo Monitor para evitar Eliminar en cascada
            modelBuilder.Entity<Domain.Entity.Monitor>()
               .HasOne(m => m.Usuario)
               .WithMany(M => M.Monitores)
               .HasForeignKey(m => m.IdUsuario)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Domain.Entity.Monitor>()
               .HasOne(m => m.Departamento)
                .WithMany(M => M.Monitores)
                .HasForeignKey(m => m.IdDepartamento)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Domain.Entity.Monitor>()
               .HasOne(m => m.Empresa)
                .WithMany(m => m.Monitores)
                .HasForeignKey(m => m.IdEmpresa)
                .OnDelete(DeleteBehavior.Restrict);

            // Configuración para evitar eliminación en cascada en Movil
            modelBuilder.Entity<Movil>()
                .HasOne(m => m.Usuario)
                .WithMany(m => m.Moviles)
                .HasForeignKey(m => m.IdUsuario)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Movil>()
                .HasOne(m => m.Departamento)
                .WithMany(m => m.Moviles)
                .HasForeignKey(m => m.IdDepartamento)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Movil>()
                .HasOne(m => m.Empresa)
                .WithMany(m => m.Moviles)
                .HasForeignKey(m => m.IdEmpresa)
                .OnDelete(DeleteBehavior.Restrict);

            // Configuración para evitar eliminación en cascada en Directorios
            modelBuilder.Entity<Directorio>()
                 .HasOne(d => d.Usuario)
                 .WithMany(u => u.Directorios)
                 .HasForeignKey(d => d.IdUsuario)
                 .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Directorio>()
                .HasOne(d => d.Departamento)
                .WithMany(d => d.Directorios)
                .HasForeignKey(d => d.IdDepartamento)
                .OnDelete(DeleteBehavior.Restrict);


            // Configuración para evitar eliminación en cascada en LineaCelulares
            modelBuilder.Entity<LineaCelular>()
                .HasOne(lc => lc.Usuario)
                .WithMany(lc => lc.LineaCelulares )
                .HasForeignKey(lc => lc.IdUsuario)  
                .OnDelete(DeleteBehavior.Restrict); 

          
            modelBuilder.Entity<LineaCelular>()
                .HasOne(lc => lc.Departamento)  
                .WithMany(lc => lc.LineaCelulares)  
                .HasForeignKey(lc => lc.IdDepartamento)  
                .OnDelete(DeleteBehavior.Restrict);

            // Configuración para evitar eliminación en cascada en LineaTelefono
            modelBuilder.Entity<LineaTelefono>()
               .HasOne(lt => lt.Departamento)
               .WithMany(lt => lt.LineaTelefonos)
               .HasForeignKey(lt => lt.IdDepartamento)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<LineaTelefono>()
                .HasOne(lt => lt.Usuario)
                .WithMany(lt => lt.LineaTelefonos)
                .HasForeignKey(lt => lt.IdUsuario)  
                .OnDelete(DeleteBehavior.Restrict);

            // Configuración para evitar eliminación en cascada en Telefono
            modelBuilder.Entity<Telefono>()
               .HasOne(t => t.Departamento)
               .WithMany(t => t.Telefonos)
               .HasForeignKey(t => t.IdDepartamento)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Telefono>()
                .HasOne(t => t.Usuario)
                .WithMany(t => t.Telefonos)
                .HasForeignKey(t => t.IdUsuario)
                .OnDelete(DeleteBehavior.Restrict);
        }




    }
}
