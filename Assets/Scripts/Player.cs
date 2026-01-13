using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;


    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        if (_playerTransform == null) _playerTransform = transform;
        _numSeedsLeft = _numSeeds;
        _numSeedsPlanted = 0;

        if (_plantCountUI != null)
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            _playerTransform.Translate(Vector3.up * _speed * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
             _playerTransform.Translate(Vector3.right * _speed * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            _playerTransform.Translate(Vector3.left * _speed * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            _playerTransform.Translate(Vector3.down * _speed * Time.deltaTime);
        }
        
        
        
        if (Input.GetKeyDown(KeyCode.Space) && _numSeedsLeft > 0)
        {
            PlantSeed();
            _numSeedsLeft-- ;
            _numSeedsPlanted++;

            if(_plantCountUI != null)
            _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);

        }
    }

    public void PlantSeed ()
    {
        GameObject newPlant = Instantiate(_plantPrefab);
        newPlant.transform.position = _playerTransform.position;
    }
}
