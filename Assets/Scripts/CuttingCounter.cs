using UnityEngine;

public class CuttingCounter : BaseCounter
{

    public override void Interact(Player player)
    {
         if (!HasKitchenObject())
        {
            // There is no KitchenObject here
            if (player.HasKitchenObject())
            {
                // Player is carrying something
                player.GetKitchenObject().SetKitchenObjectParent(this);
            } else {
                // Player not carrying anything
            }
        }
        else
        {
            // There is a kitchen object here
            if (player.HasKitchenObject()) {
                // Player is carrying sometyhing
            } else {
                // Player is not carrying anything
                // Grab the object off of the counter
                GetKitchenObject().SetKitchenObjectParent(player);
            }
        }
    }
}
