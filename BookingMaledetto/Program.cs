using BookingMaledetto._01.BusinessLayer.Interfaces;
using BookingMaledetto._01.BusinessLayer.Services;
using BookingMaledetto._02.DataAccessLayer.DAS;
using BookingMaledetto._02.DataAccessLayer.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IBookingWorkerService, BookingWorkerService>();
builder.Services.AddScoped<IGuestWorkerService, GuestWorkerService>();
builder.Services.AddScoped<IHotelWorkerService, HotelWorkerService>();
builder.Services.AddScoped<IRoomWorkerService, RoomWorkerService>();
builder.Services.AddScoped<IBookingDAS, BookingDAS>();
builder.Services.AddScoped<IGuestDAS, GuestDAS>();
builder.Services.AddScoped<IHotelDAS, HotelDAS>();
builder.Services.AddScoped<IRoomDAS, RoomDAS>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
