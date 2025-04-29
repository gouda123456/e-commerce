//namespace e_commerce.MyServices
//{
//    public static class MYServices
//    {
//        public static void AddMyServices(this IServiceCollection services,IConfiguration config)
//        {
//            services.AddDbContext<DatabaseContext>(options =>
//                options.UseSqlServer("Server=.;Database=e_commerce;Trusted_Connection=True;TrustServerCertificate=True;"));
            
//            services.AddIdentity<ApplicationUser, IdentityRole>().AddRoles<IdentityRole>()
//                .AddEntityFrameworkStores<DatabaseContext>()
//                .AddDefaultTokenProviders();
//        }
//    }
//}
