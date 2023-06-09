using HotelProject.BusinessLayer.Extensions;
using HotelProject.DataAccessLayer.Extensions;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddDbContext<MsDbContext>(); -->Bunu artik AddDataAccessLayerService icerisinde geciyoruz

builder.Services.AddDataAccessLayerServices();
builder.Services.AddBusinessLayerServices();

builder.Services.AddAutoMapper(typeof(Program)); //AutoMapper servisini tanimliyoruz ve bulundugu Assembly'de bir Class adi (Program.cs) veriyoruz.

builder.Services.AddCors(opt =>
{
    opt.AddPolicy("OtelApiCors", opts =>
    {
        opts.AllowAnyOrigin().
            AllowAnyHeader().
            AllowAnyMethod();
    });
});


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("OtelApiCors");
//app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
