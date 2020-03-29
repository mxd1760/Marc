import java.util.Scanner;

public class Dialog {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);

        System.out.println("Marcus: 'Hey, what direction do you think we should go?'");
        System.out.println("*Choose the number next to each option to select it*");
        System.out.println("1: 'We should go right.'");
        System.out.println("2: 'We should go left.'");
        System.out.println("3: 'We should continue straight.'");

        String s = in.nextLine();
        int x = Integer.parseInt(s);
        boolean done = false;

        do {
            switch (x) {
                case 1:
                    System.out.println("Marcus: 'Alright, right it is.'");
                    System.out.println("*Your party heads right and encounters an enemy ambush*");
                    done = true;
                    break;
                case 2:
                    System.out.println("Marcus: 'Alright, left it is.'");
                    System.out.println("*Your party heads left and finds a cave.*");
                    done = true;
                    break;
                case 3:
                    System.out.println("Marcus: 'Alright, forward it is.'");
                    System.out.println("*Your party continues forward for the next few hours, stopping to set up camp at night.*");
                    done = true;
                    break;
                default:
                    System.out.println("*Invalid choice, try again.*");
                    s = in.nextLine();
                    x = Integer.parseInt(s);
                    break;
            }
        } while (!done);
    }
}
