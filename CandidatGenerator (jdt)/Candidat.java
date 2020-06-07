import java.util.Random;

public class Candidat {

    private static final String TabRegions[] = {"Auvergne", "Bordelais", "Bourgogne","Bretagne", "Corse", "Nord", "Normandie","Paris", "Poitou", "Roussillon"};
    private static final String TabEcrit[] = {"Algorithmique", "Base de données", "Droit","Expression", "Gestion", "Langage C", "Langage Java","Mathématiques", "Programmation web", "Réseau", "Système", "Visual Basic .NET"};
    private static final String TabOral[] = {"Droit", "Expression", "Gestion","Mathématiques", "Réseau", "Système", "Anglais", "Chinois", "Espagnol"};
    private static final String TabPrenom[] = {"Antoine", "Thibault", "Patrice", "Annabelle", "Julien", "Jules", "Anicet", "Julie", "Juliette", "Florence", "Florent", "Carole", "Philippe", "Nicolas", "Viviane", "Pierre", "Monica", "Jean", "Marie", "Lea", "Leo", "Jaques", "Anne", "Louis", "Valentin","Sophie","François", "Xavier", "Stephane"};
    private static final String TabNom[] = { "Despres","Henrion","Vanin", "Nougaret", "Devos", "Huang", "Sacko", "Millo", "Xia", "Barthelme", "Bernard", "Moron", "Benibre", "Lepers", "Bouleau", "Coudray", "Bodin", "Silva", "Aliagas", "Damidot", "Foucault", "Plaza"};


    public static String getRegion(){
        Random rand = new Random();
        int nombreAleatoire = rand.nextInt(TabRegions.length);
        return TabRegions[nombreAleatoire];
    }

    private static String getEcrit(){
        Random rand = new Random();
        int nombreAleatoire = rand.nextInt(TabEcrit.length);
        return TabEcrit[nombreAleatoire];
    }

    private static String getOral(){
        Random rand = new Random();
        int nombreAleatoire = rand.nextInt(TabOral.length);
        return TabOral[nombreAleatoire];
    }

    public static String[] getEpreuves(){
        String tab[] = {"","","","","","","",""};
        int pos = 0;
        for(;pos<4; pos++){
            String matiere;
            boolean exist;
            do{
                exist = false;
                matiere = getEcrit();
                for (String mat:tab){
                    if(mat == matiere)
                        exist = true;
                }
            }while (exist);
            tab[pos] = matiere;
        }
        for(;pos<7; pos++){
            String matiere;
            boolean exist;
            do{
                exist = false;
                matiere = getOral();
                for (String mat:tab){
                    if(mat == matiere)
                        exist = true;
                }
            }while (exist);
            tab[pos] = matiere;
        }
        Random rand = new Random();
        int i = rand.nextInt(3);
        if(i == 0){
            String matiere;
            boolean exist;
            do{
                exist = false;
                matiere = getOral();
                for (String mat:tab){
                    if(mat == matiere)
                        exist = true;
                }
            }while (exist);
            tab[7] = matiere;
        }else if (i == 1){
            String matiere;
            boolean exist;
            do{
                exist = false;
                matiere = getEcrit();
                for (String mat:tab){
                    if(mat == matiere)
                        exist = true;
                }
            }while (exist);
            tab[7] = matiere;
        }
        return tab;
    }

    public static String getNom(){
        Random rand = new Random();
        int nombreAleatoire = rand.nextInt(TabNom.length);
        return TabNom[nombreAleatoire];
    }
    public static String getPrenom(){
        Random rand = new Random();
        int nombreAleatoire = rand.nextInt(TabPrenom.length);
        return TabPrenom[nombreAleatoire];
    }
    public static String getAdresse(){
        Random rand = new Random();
        int nbalea = rand.nextInt(2);
        if (nbalea == 1){
            return (rand.nextInt(150)+ " rue de la paix");
        }
        return "";
    }
    public static String getCP(){
        Random rand = new Random();
        return "75016";
    }
    public static String getVille(){
        Random rand = new Random();
        return "Paris";
    }
    public static int getAge(){
        Random rand = new Random();
        return rand.nextInt(54-18+1)+18;
    }
}