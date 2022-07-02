# Nicola Soroka LSW Programming Interview
 clothes shop game


First few hours i spend to chose art from Unity asset store.
I imopt only art, not take any premade mechanics.
Paint simply building, add shopkeeper and few environment elements.

Add interaction with seller.
With Cinemashine implement zoom on player while interacting with seller.
Seller can say that player is too far away.
If player is close enough, open shop UI.
Some time was taken by thinking on shop organisation conception.
Items to sell must be placed as child of "Store" game object in project hierarchy.

Buy buttons generation is ready. When shop opens, a new button generates for each child object of Store with image, name and price of this object.

First functionality of buy button: find object by name and make it child of "Player Equipment" to display it on player; deactivate button.

Items transfers in both directions between store and equipment. Buttons are updated after each operation.

Add wallet. Money amount are updated after each operation.
"Close Shop" button added.
Minimum functional shop is ready!

Add player movement by keys. For correct detecting is player in range of seller i set another layer to player and edit collision matrix to not detect collision on the same layer.

Main view is ready. Adjust sprites sorting order and colliders, add some decorations.

Finally Shop UI looks good. And added start screen with controls description. And birds sounds :)