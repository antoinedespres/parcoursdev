import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.util.Scanner;

public class App {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int nb = sc.nextInt();
        try {
            sauvegarder(nb);
        } catch (FileNotFoundException e) {
            System.err.println("Le fichier n'a pas pu être créé.");
        }
    }

    public static void sauvegarder(int nb) throws FileNotFoundException {
        try (PrintWriter out = new PrintWriter("data.parcoursdev")) {
            out.println(nb+1);
            for(int i = 1; i<= nb; i++){
                out.println(i);
                out.println(Candidat.getNom());
                out.println(Candidat.getPrenom());
                out.println(Candidat.getAdresse());
                out.println(Candidat.getCP());
                out.println(Candidat.getVille());
                out.println(Candidat.getAge());
                out.println(Candidat.getRegion());
                String tab[] = Candidat.getEpreuves();
                for(String ep:tab)
                    out.println(ep);
            }
        }
    }
}
