using UnityEngine;

public class Level_Generator : MonoBehaviour
{
    public Texture2D map;
    public GameObject prefab;
    public ColorToPrefab[] GameMapping;

    // Start is called before the first frame update
    void Start()
    {
        if(map != null && prefab!= null)
        {
            generateLevel();
        }
    }

    void generateLevel()
    {
        for(int i=0; i<map.width; i++)
        {
            for(int j=0; j<map.height; j++)
            {
                generateTile(i,j);
            }
        }
    }

    void generateTile(int x, int y)
    {
        Color pixelcolor = map.GetPixel(x, y);

        if(pixelcolor.a == 0)
        {
            return;
        }
        foreach(ColorToPrefab colorpref in GameMapping)
        {
            if(colorpref.color == pixelcolor)
            {
                for(int k =1; k<=colorpref.height; k++)
                {
                    Instantiate(prefab, new Vector3(x, k, y), new Quaternion(0, 0, 0, 0));
                }
            }
        }

    }
}
