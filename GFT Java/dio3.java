import java.io.IOException;
import java.util.Scanner;

public class DIO {
	
    public static void main(String[] args) throws IOException {
      
      Scanner ent = new Scanner(System.in);
      int n = ent.nextInt();
      
      if (n == 0) {
        
        System.out.println("E");
        
      }
      
      if (n >= 1 && n <= 35){
        
        System.out.println("D");
        
      }
      
      if (n >= 36 && n <= 60){
        
        System.out.println("C");
        
      }
      
      if (n >= 61 && n <= 85){
        
        System.out.println("B");
        
      }
      
      if (n >= 86 && n <= 100){
        
        System.out.println("A");
        
      }


    }
	
}
