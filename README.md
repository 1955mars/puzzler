![](/Puzzler/Assets/UdacityVR/Images/1.JPG "Puzzler - VR breakdown")

# Introduction

Since the digital revolution, we have been staring at these flat screens of different sizes (the one you are looking at right now) for all kind of experiences. Any application built for these rectangular boxes only allowed the user to experience it as an outsider. For the first time, Virtual Reality is allowing us to step inside a software application and experience it by being there and becoming part of it.

A well-designed VR application can immerse a user completely inside a virtual world and give magical experiences (people will love to come back) that are impossible to get from flat screens. On the other hand, a badly designed VR experience can cause the user extreme discomfort with the induction of nausea, headache, vomiting etc., (the headset would have been thrown outside).  As a VR application invites a user into its world, it is the application’s sole responsibility to take care of the user in all possible ways and let the guest enjoy the experience with ease and comfort.

Hence the design of any VR application must be completely user-centric and the development should be an iterative process with lots of user testing and feedback. In this article, I’m going to present the design and development process that I have taken while building a simple mobile VR application called PUZZLER for google cardboard as a part of UDACITY VR Nano-Degree program.

Here is the playthrough video of the final game. 

[![Alt text](https://img.youtube.com/vi/vO4ItAbAqm0/0.jpg)](https://youtu.be/vO4ItAbAqm0)

# [Download Android apk file from here](https://drive.google.com/file/d/1AlOb4MgVXfcZ4tBx2TMR38aMQhhjWPOs/view)

## Statement of Purpose

Puzzler is a modern version of Simon Says game with setting in a magical dungeon. The game uses five orbs to show a pattern, by lighting each individual orb in an order, within a short period of time. The user has to remember the pattern and select the orbs in the correct order. The game puts the user inside a dungeon and to escape from it the puzzle needs to be solved.

This game is targeted at the audience with minimal experience in VR, but enthusiastic enough to explore about it.

## Persona

![](/Puzzler/Assets/UdacityVR/Images/2.JPG "Persona")

## Designs, Sketches & Models

### 1. Dungeon

I have come up with the below sketches for the layout of the dungeon.

![](/Puzzler/Assets/UdacityVR/Images/3.JPG "Dungeon sketches")

Below is the final model of the dungeon created in Unity3D. I have used a combination of lights and audio to create a magical ambiance.

![](/Puzzler/Assets/UdacityVR/Images/4.JPG "Dungeon")

### 2. User Interface

Puzzler requires two billboard type of GUIs, one for start and another for the restart. I wanted to have an UI that is both simple and intuitive to use by any novice VR user. Below are my sketches.

![](/Puzzler/Assets/UdacityVR/Images/5.JPG "User Interface Sketch 1")

![](/Puzzler/Assets/UdacityVR/Images/6.JPG "User Interface Sketch 2")

Below is the final User Interface. I have implemented both gaze click & gaze timeout for selection.

![](/Puzzler/Assets/UdacityVR/Images/7.JPG "User Interface")

## User testing
I wanted to get honest feedback about this application. So, I chose one of my friend whom I thought would be the right user for testing this app. A short intro about him below

*Chandu:*
He is my roommate and a good critic of my works. He has a great aesthetic sense and cares for the finest details in everything. He is new to Virtual Reality.

**User Test - 1:** What do you feel about the setting, scale & mood of the scene?

*Chandu:* I feel the door is a bit smaller in height. The torches are heavily lit inside. The audio and overall setting makes me feel like this place is haunted.

    Increased the overall size of the dungeon. Dimmed the torch lights.  
    
**User Test - 2:** How is the movement? 

*Chandu:* I felt a sudden jerk but I liked it. The movement is smooth and comfortable. I feel like the second movement to the restart UI after winning the game is faster when compared to the first movement that takes us inside the dungeon.

      Reduced the speed for the second movement and made it match with the first one.  
      
**User Test - 3:** How is the overall feel of the VR experience?  Any suggestions ?

*Chandu:* The game looked cool with all the audio and visual feedback. I would like to see fire coming out of the torches. You can even add items like spider net, some insects crawling around etc., to make this place look more haunted.

      I would love to add these enhancements in the next version of this game. 
      
# Breakdown of final piece

The final piece is shown in the video below but the overall gameplay goes like this.
1. The game begins with an introductory UI (Start UI shown in the sketches) containing a GO button. The user can select the GO button by either gazing at the button with the reticle pointer and clicking the controller button or by just gazing at the button and waiting for 2sec. The player will be transported into the dungeon.
2. Inside the dungeon, Simon Says' game will be presented to the user with the orbs. A random 5-orb pattern will be shown to the user by lighting up each individual orb. The player has to repeat the pattern in the correct order by gazing at the orbs with the reticle pointer and selecting them in the same way as did in the above step. 
3. There is an audio feedback for a right and wrong pattern selection. The same pattern will repeat in case the user selects a wrong pattern of orbs. 
4. Upon successful completion of the puzzle, the user will be transported outside of the dungeon from the exit door. Here the user will be presented with a restart UI.

# Conclusion

It's an enriching experience working throughout this project. I have worked on a few VR projects before but this is the first time I have followed a proper design and development process until the end. I realized the importance of user testing and getting feedback during the early development stage of the project. Seeing the project getting better after every iteration is an awesome feeling. 

# Next steps..

There is a lot of room for improvement in this work. I would like to consider building a bigger dungeon with multiple rooms and a different set of puzzles. 
