using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class AlgebraTests
    {
        /*[Test]
                public void VerifyLetterInput()
                {
                    
                
                    // Arrange
                   TestVerify myController = new TestVerify();
                    
                    
        
                    
                    // Act
                    myController.VerifyText("t");
                    int checknum = myController.checknum;
        
                    //Assert
                    Assert.AreEqual(0,checknum);
        
                    // Use the Assert class to test conditions
                }*/
                
                // Todo: Test 2 -- Check if the condition catches with a number is below 0 or above 10

                /*[Test]
                public void Test_above_10_or_below_0()
                {
                    // Arrange

                    TestVerify myController = new TestVerify();

                    // Act
                    myController.VerifyText("12");
                    int checknum = myController.checknum;


                    // Assert
                    Assert.AreEqual(111,checknum);




                }
                
                // Todo: Test 3 -- Check if the condition catches with a number is below 0 or above 10
                [Test]
                public void Test_negative_input()
                {
                    // Arrange
                
                    TestVerify myController = new TestVerify();
                
                    // Act
                    myController.VerifyText("-1");
                    int checknum = myController.checknum;
                
                
                    // Assert
                    Assert.AreEqual(111,checknum);
                    
                    
                    
                    
                }*/
                
                // TODO: Test for MultiStepInteration.cs class
                
                // Todo: Test 1 -- Check if the funtion AdaptToStep run to the end

               [Test]
               public void Test_MultiStepITIndex()
               {
                   // Arrange
                   MultiStepIT multiStepIt = new MultiStepIT();
                   
                   // Act
                   multiStepIt.checkIincrement(10);
                   int checker = multiStepIt.ii;

                   // Asser
                   Assert.Greater(checker,10);
               }
               
               [Test]
               public void Test_MultiStepITStep()
               {
                   // Arrange
                   MultiStepIT multiStepIt = new MultiStepIT();
                   
                   // Act
                   multiStepIt.checkCurrentStepIndex(10);
                   int checker = multiStepIt.currentStep;
                   
                   // Assert
                   Assert.Greater(checker,10);
               }
               
               [Test]
               public void Test_MultiStepITNumber()
               {
                   // Arrange
                   MultiStepIT multiStepIt = new MultiStepIT();
                   
                   // Act
                   multiStepIt.checkCurrentNumberofCorrectAnswer(10);
                   int checker = multiStepIt.currentNumber;

                   // Assert
                   Assert.Greater(checker,10);
               }
               
               [Test]
               public void Test_MultiCanvasPossible()
               {
                   // Arrange
                   MultiCanvas multicanvas = new MultiCanvas();

                   // Act
                   multicanvas.checkpossibleTries(10);
                   int checker = multicanvas.possibleTries;

                   // Assert
                   Assert.Less(checker,10);
               }
               
               [Test]
               public void Test_MultiCanvasAnswers()
               {
                   // Arrange
                   MultiCanvas multicanvas = new MultiCanvas();

                   // Act
                   multicanvas.checkcorrentAnswersCount(10);
                   int checker = multicanvas.correctAnswersCount;

                   // Assert
                   Assert.Greater(checker,10);
               }
               
               [Test]
               public void Test_MultiCanvasIndex()
               {
                   // Arrange
                   MultiCanvas multicanvas = new MultiCanvas();
                   
                   // Act
                   multicanvas.checkCurrentIndex(10);
                   int checker = multicanvas.currentIndex;

                   // Assert
                   Assert.Greater(checker,10);
               }
               
               [Test]
               public void Test_MultiCanvasIsCorrent()
               {
                   // Arrange
                   MultiCanvas multicanvas = new MultiCanvas();

                   // Act
                   bool status = false;
                   multicanvas.checkIsCorrent(status);
                   bool checker = multicanvas.corrent;

                   // Assert
                   Assert.IsTrue(checker);
               }
               
               [Test]
               public void Test_MultiCanvasIsShould()
               {
                   // Arrange
                   MultiCanvas multicanvas = new MultiCanvas();

                   // Act
                   bool status = false;
                   multicanvas.checkShouldDiables(status);
                   bool checker = multicanvas.shouldDisable;

                   // Assert
                   Assert.IsTrue(checker);
               }
               
               #region MoveAlongPoint.cs
               
               // TODO: Test for MoveAlongPoint.cs
               // // Test the logic Current Index increment
        [Test]
        public void Test_MoveAlongLogicCurrentIndex()
        {
            // check the increment of CurrentIndex
            // // Arrange
            
            MoveAlongTest moveAlongTest = new MoveAlongTest();
            int currentDestIndex = 4;
            int destPLen = 8;
            bool enabled = true;
            
            // Act
            moveAlongTest.checkLogic(0.4f,currentDestIndex,destPLen,enabled);
            int testindex = moveAlongTest.testCurrentDestIndeex;
            
            // Assert
            Assert.Greater(testindex,currentDestIndex);
        }
        
        // Test the logic if enable is false
        [Test]
        public void Test_MoveAlongLogicEnabled()
        {
            // check the increment of CurrentIndex
            // Arrange
            MoveAlongTest moveAlongTest = new MoveAlongTest();
            int currentDestIndex = 8;
            int destPLen = 4;
            bool enabled = true;
            
            // Act
            moveAlongTest.checkLogic(0.4f,currentDestIndex,destPLen,enabled);
            bool testenabled = moveAlongTest.testEnabled;
            
            // Assert
            Assert.IsFalse(testenabled);
        }
        #endregion
        
        #region ProgressBar.cs
        
        // TODO: Test the ProgressBar.cs
        // Test the logic for update() function
        
        [Test]
        public void Test_UpdateLogic()
        {
            // Arrange
            
            ProgressTestBar progressTestBar = new ProgressTestBar();
            float slidevalue = 5;
            // Act
            
            progressTestBar.checkUpdateLogic(slidevalue,10f,10f,2f);
            float testslidevalue = progressTestBar.testSlidevalue;
            // Assert
            Assert.Greater(testslidevalue,slidevalue);
            Assert.AreEqual(25,testslidevalue);
        }
        
        // Test the logic for IncrementIndex() funtion
        
        [Test]
        public void Test_IncrementLogic()
        {
            // Arrange
            
            ProgressTestBar progressTestBar = new ProgressTestBar();
            float slidevalue = 5;
            float testprog = 0;
            // Act
            
            progressTestBar.checkIncrementLogic(testprog,slidevalue,5);
            float testTargetProgress = progressTestBar.testTargetProgress;
            // Assert
            Assert.Greater(testTargetProgress,0);
            Assert.AreEqual(10,testTargetProgress);
        }
        #endregion
        
        #region ProgressBar2.cs
        
        // TODO: Test the ProgressBarTwo.cs
        // Test the logic for update() function
        [Test]
        public void Test_UpdateLogicTwo()
        {
            // Arrange
            ProgressTestBarTwo progressTestBar = new ProgressTestBarTwo();
            float slidevalue = 30;
            // Act
            progressTestBar.checkUpdateLogic(slidevalue,5f,10f,2f);
            float testslidevalue = progressTestBar.testSlidevalue;
            
            // Assert
            Assert.Less(testslidevalue,slidevalue);
            Assert.AreEqual(10, testslidevalue);
        }
        
        // Test the logic for IncrementIndex() funtion
        
        [Test]
        public void Test_IncrementLogicTwo()
        {
            // Arrange
            
            ProgressTestBarTwo progressTestBar = new ProgressTestBarTwo();
            float slidevalue = 10;
            float testprog = 20;
            // Act
            
            progressTestBar.checkIncrementLogic(testprog,slidevalue,5);
            float testTargetProgress = progressTestBar.testTargetProgress;
            
            // Assert
            Assert.Less(testTargetProgress,20);
            Assert.AreEqual(5,testTargetProgress);
        }
        #endregion
        
/*        #region RigidBodyActivator.cs
        
        //TODO: Test for nullity in RigidbodyActivator
        
        [Test]
        public void Test_NullRigidbody()
        {
            // Arrange
            RigbodyTest activator = new RigbodyTest();
            
            // Act
            bool checker = activator.TestRigidNull();
            
            // Assert
            Assert.IsTrue(checker);
        }
        #endregion*/
        
/*        #region WayPoint.cs
        
        // TODO: Test for Nullity in Waypoint
        [Test]
        public void Test_NullMeshRenderer()
        {
            // Arrange
            WaypointTest activator = new WaypointTest();
            
            // Act
            bool checker = activator.checkMeshNull();
            
            // Assert
            Assert.IsTrue(checker);
        }
        #endregion*/
    }
}
