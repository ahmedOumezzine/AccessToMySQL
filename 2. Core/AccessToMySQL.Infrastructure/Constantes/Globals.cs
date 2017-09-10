using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccessToMySQL.Infrastructure.Constantes
{
    public class Globals
    {
        #region Constante sCommunes
        public static readonly string LOG_FILE_FOLDER = "LogFileFolder";
        public static readonly string NB_FILE_MAX = "NbMaxFichLog";
        public static readonly string SYNCHRO_CONFIG = "ItfGenriqueFuturaConfig.xml";
        public static readonly string CNX_FUTURA = "FuturaApplication";
      
        //public static readonly string FUTURA = "FUTURA";
  
        public static readonly string MODE_TRACE = "ModeTrace";
        public static readonly string INTERFACE_DOSS_PAT = "InterfaceDossierPatient";
        public static readonly string INTERFACE_MVT = "InterfaceMouvement";
        public static readonly string INTERFACE_DEMANDE_HOSP = "InterfaceDemandeHosp";

        public static readonly string INTERFACE_RESERVATION = "InterfaceReservation";
        public static readonly string INTERFACE_RDV = "InterfaceRDV";
        public static readonly string INTERFACE_INTERVENANT = "InterfaceIntervanant";
        public static readonly string INTERFACE_CONTACT_MEDICAL = "InterfaceContactMedical";
        public static readonly string INTERFACE_DOC = "InterfaceDocument";
        public static readonly string INTERFACE_COUVERTURE = "InterfaceCouverture";
        public static readonly string INTERFACE_ACTES = "InterfaceActes";
        public static readonly string INTERFACE_CONTACTS = "InterfaceContacts";

        public static readonly string IS_PROV_DEST_FK = "IsProvDestFK";

        public static readonly string RETOURLIGNE = "\r\n";
        public static readonly string INTERFACE_COMMUNE = "InterfaceCommune";

        public static readonly string DATA_BASE_CULTURE = "CultureBaseDonnees";
        public static readonly string CODE_DEFAUT_UF = "CodeDefautUf";
        public static readonly string CREATION_DOSS_IDENT = "CreationDossierIdentite";
        public static readonly string NUM_DOSS_DEFAUT = "DOSS_TMP";
        public static readonly string SORT_DEF_CLOT_DOSSIER = "SortDefClotureDossier";
        public static readonly string PAS_NOUV_DOSS_SI_DOSS_OUVERT_MEME_UF = "PasNouvDossSiDossOuvMemeUf";
        public static readonly string RECH_NOM_PREN_SEX_DATE_NAIS = "RechercheNomPrenomSexeDateNaiss";
        public static readonly string ITF_MVT_UNIQ_NUM_DOSS_EXT = "ItfInMvUniquementNumDossierExt";
        public static readonly string ITF_DOSS_UNIQ_IPP_EXT = "ItfInDossUniquementIppExt";
        public static readonly string DUREE_RESER_DEFAULT = "DUREE_RESER_DEFAULT";
        public static readonly string CORRESPONDANCE_UF = "CorrespondanceUF";

        #endregion
    }

    #region Enumértion Futura

    public enum TypeMouvementFutura
    {
        EntreeHosp = 1,
        EntreeMutation = 2,
        RetourPermission = 3,
        RetourTransfert = 4,
        EntreeEnUrgence = 5,
        EntreeConsultation = 6,
        EntreeSeance = 7,
        SortieDefinitive = 10,
        SortieMutation = 11,
        SortiePermission = 12,
        SortieTransfert = 13,
        FinSeance = 14,
        ChangementLit = 99,
    }

    public enum Operation
    {
        Information = 0,
        Creation = 1,
        Modification = 2,
        Suppression = 3
    }

    public enum EtatDossier
    {
        Preadmission = 1,
        Admission = 2,
        Sortie = 3
    }

    public enum TypeDossier
    {     //hospitalisation complete
        HC = 1,
        //consultation externe 
        CE = 2,
        //sceance periodique
        Ambulatoire = 3,
        //
        PreAdmission = 4,
        //
        PassageUrgence = 6,
        //cas repris des identité seulement 
        DossierTemporaire = 9
    }

    public enum Civilite
    {
        M = 1,
        Mme = 2,
        Mlle = 3
    }

    public enum TypeMessageInterface
    {
        IdentiteDossier = 1,
        Mouvement = 2,
        Reservation = 3,
        RDV = 4,
        Intervenant = 5,
        Document = 6,
        ContactMedical = 7,
        CouvertureCaisse = 8,
        CouvertureMutuel = 9,
        MvtStock = 10,
        GestionArticle = 11,
        DemandeHosp = 12,
        ActesCcam = 13,
        ActesCsar = 14,
    }

    public enum CodeErrorDossier
    {
        Traite = 1,
        DossierExistant = 2,
        DonneeObligatoireManquant = 3,
        MouvementEntreeIntrouvable = 4,
        DossierIntrouvable = 5,
        OperationInconnu = 6
    }

    public enum CodeErrorContact
    {
        Traite = 1,
        ContactExistant = 2,
        DonneeObligatoireManquant = 3,
        PatientIntrouvable = 4,
        ContactIntrouvable = 5,
        OperationInconnu = 6
    }

    public enum CodeErrorMouvement
    {
        Traite = 1,
        MouvementExistant = 2,
        DonneeObligatoireManquant = 3,
        DossierIntrouvable = 4,
        MouvementIntrouvable = 5,
        OperationInconnu = 6,
        CreeAvecDonneeManquant = 7
    }

    public enum EtatDemandeHosp
    {
        EnAttentePlanification = 0,
        Planifiee = 1,
        Refusee = 2,
        Annulee = 3,
        Terminee = 4,
        Toutes = 5,
        Modifiee = 6,
        EnAttenteDeValidation = 7,
        Admis = 8,
    }

    public enum CreationDossier
    {
        Mouvement = 0,
        DemandeHosp = 1
    }

    #endregion
}
