# exhibition-attraction-screen
A simple script to restart a game and to show an attraction screen with a video for exhibitions

Place the prefab AttractionScreen into one of your main game scenes and define the options below:

![image](https://user-images.githubusercontent.com/58563011/167408657-d5c528f0-32a1-43cc-9fd5-0e060fd3fd99.png)

Take care that the scene name is also present in the build index list of your project. 

Fine-tune the video settings in the Video Player component and link the correspondig video file or use the URL path option. 

![image](https://user-images.githubusercontent.com/58563011/167408528-916b0408-c6d2-4bca-9b7e-0d0642223d74.png)

IMPORTANT: if you use FMOD Studio for your sounds it won't be able to play the music of the video clip. (which in most cases is fine for exhibitions) 

If the image of the video looks odd, check the size of the render texture AttractionScreenRT or if the child object "Raw Image" of the AttractionScreen canvas is not well placed.

![image](https://user-images.githubusercontent.com/58563011/167408459-f8aa578b-d10f-4aeb-83c1-df38b499b39d.png)

In order to detect any input correctly you might change this line in favour of your input tool or your game controls: 

![image](https://user-images.githubusercontent.com/58563011/167409113-345fc185-07a7-40e4-af68-aea3a4b0755a.png)
