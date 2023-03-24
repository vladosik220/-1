public class Car {
    public double MaxSpeed;

    public Car() {
        this.MaxSpeed = 200;
    }

    public Car(double maxSpeed) {
        this.MaxSpeed = maxSpeed;
    }

    public double CalculateTime(double distance) {
        return distance / MaxSpeed;
    }
}
