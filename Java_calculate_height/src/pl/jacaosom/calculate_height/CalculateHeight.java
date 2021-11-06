package pl.jacaosom.calculate_height;

import java.util.InputMismatchException;

public class CalculateHeight extends GetData {
    public void ChooseTask(){
        int  choice = 0;
        boolean isChoiceCorrect4 = true, isChoiceCorrect5 = true;

        do {
            do {
                try{
                    System.out.println("Choose an action :\n1-Calculate heights.\n0-End the program.");
                    System.out.print("Type: ");
                    choice = input.nextInt();
                    isChoiceCorrect4 = false;
                }
                catch(InputMismatchException ime){
                    System.out.println("!EROOR! Please enter correct value");
                    input.nextLine();
                }
            }while(isChoiceCorrect4);


            switch (choice){
                case 1:
                    DoTask();
                    break;
                case 0:
                    isChoiceCorrect5 = false;
                    break;
                default:
                    System.out.println("!ERROR! Choose again!");
                    break;
            }

        }while (isChoiceCorrect5);
    }

    public void Heights(){
        int start = 0;
        double result, result2, diffHeight = height1 - height2;
        System.out.println("Heights every 2 meters: ");
        for (int i = 2; i < distance; i += 2){
            result = ((diffHeight * i) / distance);
            result2 = (height1 - result);
            result2 *= 100;
            result2 = Math.round(result2);
            result2 /= 100;
            System.out.println("H" + ++start + " = " + result2);
        }
    }
    public void GetPoints(){
        getDistance();
        getHeight1();
        getHeight2();
    }
    public void DoTask(){
        GetPoints();
        Heights();
    }
    public void HelloAndAuthor(){
        System.out.println("\t\tWelcome to the height calculate program!");
        System.out.println("\t\tAuthor: Jacek Filipski");
        System.out.println("\t\tVersion: 1.0\n");
    }

}
