import java.io.IOException;
import java.util.Scanner;

public class DIO {
	
    public static void main(String[] args) throws IOException {
      
      Scanner ent = new Scanner(System.in);
      int a = ent.nextInt();
        
        for(int i = 1; i <= a; i++){
          
          if (i % 2 == 0) {
            
            int b = i;
            System.out.println(b);
            
          }
          
        }
    	
    }
	
}
