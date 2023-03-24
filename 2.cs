public class Car {
    public string Name;
    public double MaxSpeed;

    public Car(string name, double maxSpeed) {
        this.Name = name;
        this.MaxSpeed = maxSpeed;
    }

    public double CalculateTime(double distance) {
        return distance / MaxSpeed;
    }
}
