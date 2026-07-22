var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();

  //Base Class
  public class Employee
  { 
    //Data Members  
    private double basic_sal;
    private double hra;
    private double da;

    //Member functions

    //Constructor overloading
    public Employee(){
          this.basic_sal=5000;
          this.hra=1200;
          this.da=700;
    }

    public Employee(double bsal, double hra, double da){
        this.basic_sal=bsal;
        this.hra=hra;
        this.da=da;
    }

    public virtual double CalculateSalary ()
    {
      return basic_sal + hra+ da;
    }

    public override string ToString(){
      return base.ToString() +
      "Basic Salary ="+ basic_sal +
      "HRA ="+ hra +
      "Daily Allowance ="+ da;
    }
  }

  //Derived Class
  public class Manager: Employee
  { 
    private double incentive;

    public Manager():base(){
      this.incentive=0;
    }

    public Manager(double bsal, double hra, double da, double incentive):
                  base(bsal, hra, da)  //Member Initialized List
    {
      this.incentive=incentive;
    }

    public double CalculateIncentives ()
    {
      //code to calculate incentives
      return incentive*2;
    }
    
    //Method overriding
    public override double CalculateSalary ()
    {
      return base.CalculateSalary() + CalculateIncentives();
    }

    public override string ToString(){
      return base.ToString() + "Incentive ="+ this.incentive;
    }
  }

  static void Main ()
  {
var manager = new Manager();
  double inc = manager.CalculateIncentives();
  double sal = manager.CalculateSalary();
  Console.WriteLine(inc);
  Console.WriteLine(sal);
  }