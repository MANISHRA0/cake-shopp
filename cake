public class Cake {
   
    private String cakeId;
    private String name;
    private String description;
    private double price;
    private int quantityAvailable;

    
    public Cake(String cakeId, String name, String description, double price, int quantityAvailable) {
        this.cakeId = cakeId;
        this.name = name;
        this.description = description;
        this.price = price;
        this.quantityAvailable = quantityAvailable;
    }

 
    public void displayDetails() {
        System.out.println("Cake ID: " + cakeId);
        System.out.println("Name: " + name);
        System.out.println("Description: " + description);
        System.out.println("Price: $" + price);
        System.out.println("Quantity Available: " + quantityAvailable);
    }

  
    public void updateQuantity(int newQuantity) {
        this.quantityAvailable = newQuantity;
        System.out.println("Quantity updated successfully. New quantity: " + newQuantity);
    }

   
    public double calculateTotalCost(int quantity) {
        double totalCost = price * quantity;
        return totalCost;
    }

    public static void main(String[] args) {
   
        Cake myCake = new Cake("C001", "Chocolate Cake", "Delicious chocolate cake", 25.99, 10);

        
        myCake.displayDetails();


        myCake.updateQuantity(15);

        
        int orderedQuantity = 5;
        double totalCost = myCake.calculateTotalCost(orderedQuantity);
        System.out.println("Total cost for " + orderedQuantity + " cakes: $" + totalCost);
    }
}

