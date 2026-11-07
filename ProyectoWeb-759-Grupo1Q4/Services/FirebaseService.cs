using Google.Cloud.Firestore;
namespace ProyectoWeb_759_Grupo1Q4.Services;

public class FirebaseService
{
    private readonly FirestoreDb _firestoreDb;

    public FirebaseService()
    {
        var crendetialPath = Path.Combine(AppContext.BaseDirectory, "config", "firebase-credentials.json");
        
        Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", crendetialPath);
        
        _firestoreDb = FirestoreDb.Create("prograweb-749");
    }
    public CollectionReference GetCollection(string collectionName)
    {
        return _firestoreDb.Collection(collectionName);
    }
}