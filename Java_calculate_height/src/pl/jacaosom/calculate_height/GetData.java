package pl.jacaosom.calculate_height;

import java.util.InputMismatchException;
import java.util.Scanner;

public class GetData {
    Scanner input = new Scanner(System.in);
    public double distance, height1, height2;
    boolean isInputCorrect1 = true;
    boolean isInputCorrect2 = true;
    boolean isInputCorrect3 = true;

    public GetData(){
    }

    public double getDistance(){
        do{
            try{
                System.out.println("Enter distance between 2 points:");
                distance = input.nextDouble();
                isInputCorrect1 = false;
            }
            catch(InputMismatchException ime){
                System.out.println("!EROOR! Please enter correct value");
                input.nextLine();
            }
        }while (isInputCorrect1);
        return distance;
    }

    public double getHeight1() {
        do{
            try{
                System.out.println("Enter height's first point:");
                height1 = input.nextDouble();
                isInputCorrect2 = false;
            }
            catch(InputMismatchException ime){
                System.out.println("!EROOR! Please enter correct value");
                input.nextLine();
            }
        }while(isInputCorrect2);
        return height1;
    }

    public double getHeight2() {
        do{
            try{
                System.out.println("Enter height's second point:");
                height2 = input.nextDouble();
                isInputCorrect3 = false;
            }
            catch(InputMismatchException ime){
                System.out.println("!EROOR! Please enter correct value");
                input.nextLine();
            }
        }while (isInputCorrect3);
        return height2;
    }
}
