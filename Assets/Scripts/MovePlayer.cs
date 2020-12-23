using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Transform player;
 

    void OnMouseDrag()
    {
        if (!Player.lose)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.x = mousePos.x > 4.0f ? -2.0f : mousePos.x;
            mousePos.x = mousePos.x < -3.5f ? 2.75f : mousePos.x;
            player.position =new Vector2(mousePos.x, player.position.y);

            if (mousePos.x == 1.7f)
                player.position = new Vector2(-1.7f, player.position.y);
            if (mousePos.x == -1.7f)
                player.position = new Vector2(1.7f, player.position.y);
        }
        
    }
}
