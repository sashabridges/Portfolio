package mabi_app;
import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import javax.sound.midi.*;

public class Controling {
	   private JFrame mainFrame;
	   private JLabel headerLabel;
	   private JLabel statusLabel;
	   private JPanel controlPanel;
	   private JPanel skillPanel;
	   
	   public Controling(){
		   prepareGUI();
		   }
	   
	   
	public static void main(String[] args) {
		// TODO Auto-generated method stub
	    Controling Controling = new Controling();      
	      Controling.showRadioButton();
	      Controling.showSmashIcon();
	}
	
	private void prepareGUI(){
	      mainFrame = new JFrame("Mabinogi Skill Calculator");
	      mainFrame.setSize(600,800);
	      mainFrame.setLayout(new GridLayout(3, 3));
	      
	      mainFrame.addWindowListener(new WindowAdapter() {
	         public void windowClosing(WindowEvent windowEvent){
	            System.exit(0);
	         }        
	      });    
	      headerLabel = new JLabel("", JLabel.CENTER);        
	      statusLabel = new JLabel("",JLabel.CENTER);   
	      statusLabel.setSize(100,100);

	      controlPanel = new JPanel();
	      controlPanel.setLayout(new FlowLayout());
	      
	      skillPanel = new JPanel();
	      skillPanel.setLayout(new FlowLayout());

	      mainFrame.add(headerLabel);
	      mainFrame.add(controlPanel);
	      mainFrame.add(skillPanel);
	      mainFrame.add(statusLabel);
	      mainFrame.setVisible(true);  
	   }
	
	 private void showRadioButton(){
	      headerLabel.setText("Welcome!"); 

	      final JRadioButton radHuman = new JRadioButton("Human", true);
	      final JRadioButton radElf = new JRadioButton("Elf");
	      final JRadioButton radGiant = new JRadioButton("Giant");
	      
	      
	      
	      JLabel apLabel = new JLabel("How much AP do you have?");
	      final JTextField userText = new JTextField(10);
	      JButton returnButton = new JButton("Return");
	      JLabel returnApLabel = new JLabel("");
	      
	      returnButton.addActionListener(new ActionListener() {
	    	  public void actionPerformed(ActionEvent e) {
	    		  String data = userText.getText();
	    		   data = "AP: " + data;
	    		   returnApLabel.setText(data);
	    	  }
	      });
	      
	      // get the value of the user's AP
	      //String currentCost = returnApLabel.getText();
	      //int userAP = Integer.parseInt(currentCost);
	      int userAP = 5000;
	      
	      JLabel currentCostLabel = new JLabel("Current cost: ");
	      JLabel remainingLabel = new JLabel("AP remaining: ");

	      radHuman.setMnemonic(KeyEvent.VK_C);
	      radElf.setMnemonic(KeyEvent.VK_M);
	      radGiant.setMnemonic(KeyEvent.VK_P);
	      
	      // race listeners
	      radHuman.addItemListener(new ItemListener() {
	         public void itemStateChanged(ItemEvent e) {         
	            statusLabel.setText("Human RadioButton: " 
	               + (e.getStateChange()==1?"checked":"unchecked"));
	         }           
	      });
	      radElf.addItemListener(new ItemListener() {
	         public void itemStateChanged(ItemEvent e) {             
	            statusLabel.setText("Elf RadioButton: " 
	               + (e.getStateChange()==1?"checked":"unchecked")); 
	         }           
	      });
	      radGiant.addItemListener(new ItemListener() {
	         public void itemStateChanged(ItemEvent e) {             
	            statusLabel.setText("Giant RadioButton: " 
	               + (e.getStateChange()==1?"checked":"unchecked"));
	         }           
	      });
	      
	      // smash radio buttons
	      final JRadioButton radSmashF = new JRadioButton("Smash rF", true);
	      final JRadioButton radSmashE = new JRadioButton("Smash rE");
	      final JRadioButton radSmashD = new JRadioButton("Smash rD");
	      final JRadioButton radSmashC = new JRadioButton("Smash rC");
	      final JRadioButton radSmashB = new JRadioButton("Smash rB");
	      final JRadioButton radSmashA = new JRadioButton("Smash rA");
	      final JRadioButton radSmash9 = new JRadioButton("Smash r9");
	      final JRadioButton radSmash8 = new JRadioButton("Smash r8");
	      final JRadioButton radSmash7 = new JRadioButton("Smash r7");
	      final JRadioButton radSmash6 = new JRadioButton("Smash r6");
	      final JRadioButton radSmash5 = new JRadioButton("Smash r5");
	      final JRadioButton radSmash4 = new JRadioButton("Smash r4");
	      final JRadioButton radSmash3 = new JRadioButton("Smash r3");
	      final JRadioButton radSmash2 = new JRadioButton("Smash r2");
	      final JRadioButton radSmash1 = new JRadioButton("Smash r1");
	      final JRadioButton radSmashDan1 = new JRadioButton("Smash Dan 1");
	      final JRadioButton radSmashDan2 = new JRadioButton("Smash Dan 2");
	      final JRadioButton radSmashDan3 = new JRadioButton("Smash Dan 3");
	      
	      // smash array
	      int smashAP[] = {1, 5, 9, 13, 18, 24, 31, 39, 49, 61, 81, 103, 127, 153, 183, 190, 200, 215};
	      
	      // smash listeners
	      radSmashF.addItemListener(new ItemListener() {
		         public void itemStateChanged(ItemEvent e) {         
		            currentCostLabel.setText("Current Cost: " + smashAP[0]); 
		            int changeData = userAP - smashAP[0];
		            remainingLabel.setText("AP Remaining: " + changeData);
		         }           
		      });
	      
	      radSmashE.addItemListener(new ItemListener() {
		         public void itemStateChanged(ItemEvent e) {         
		            currentCostLabel.setText("Current Cost: " + smashAP[1]); 
		            int changeData = userAP - smashAP[1];
		            remainingLabel.setText("AP Remaining: " + changeData);
		         }           
		      });
	      
	      radSmashD.addItemListener(new ItemListener() {
		         public void itemStateChanged(ItemEvent e) {         
		            currentCostLabel.setText("Current Cost: " + smashAP[2]); 
		            int changeData = userAP - smashAP[2];
		            remainingLabel.setText("AP Remaining: " + changeData);
		         }           
		      });
	      
	      radSmashC.addItemListener(new ItemListener() {
		         public void itemStateChanged(ItemEvent e) {         
		            currentCostLabel.setText("Current Cost: " + smashAP[3]); 
		            int changeData = userAP - smashAP[3];
		            remainingLabel.setText("AP Remaining: " + changeData);
		         }           
		      });
	      
	      radSmashB.addItemListener(new ItemListener() {
		         public void itemStateChanged(ItemEvent e) {         
		            currentCostLabel.setText("Current Cost: " + smashAP[4]); 
		            int changeData = userAP - smashAP[4];
		            remainingLabel.setText("AP Remaining: " + changeData);
		         }           
		      });
	      
	      radSmashA.addItemListener(new ItemListener() {
		         public void itemStateChanged(ItemEvent e) {         
		            currentCostLabel.setText("Current Cost: " + smashAP[5]); 
		            int changeData = userAP - smashAP[5];
		            remainingLabel.setText("AP Remaining: " + changeData);
		         }           
		      });
	      
	      radSmash9.addItemListener(new ItemListener() {
		         public void itemStateChanged(ItemEvent e) {         
		            currentCostLabel.setText("Current Cost: " + smashAP[6]); 
		            int changeData = userAP - smashAP[6];
		            remainingLabel.setText("AP Remaining: " + changeData);
		         }           
		      });
	      
	      radSmash8.addItemListener(new ItemListener() {
		         public void itemStateChanged(ItemEvent e) {         
		            currentCostLabel.setText("Current Cost: " + smashAP[7]); 
		            int changeData = userAP - smashAP[7];
		            remainingLabel.setText("AP Remaining: " + changeData);
		         }           
		      });
	      
	      radSmash7.addItemListener(new ItemListener() {
		         public void itemStateChanged(ItemEvent e) {         
		            currentCostLabel.setText("Current Cost: " + smashAP[8]); 
		            int changeData = userAP - smashAP[8];
		            remainingLabel.setText("AP Remaining: " + changeData);
		         }           
		      });
	      
	      radSmash6.addItemListener(new ItemListener() {
		         public void itemStateChanged(ItemEvent e) {         
		            currentCostLabel.setText("Current Cost: " + smashAP[9]); 
		            int changeData = userAP - smashAP[9];
		            remainingLabel.setText("AP Remaining: " + changeData);
		         }           
		      });
	      
	      radSmash5.addItemListener(new ItemListener() {
		         public void itemStateChanged(ItemEvent e) {         
		            currentCostLabel.setText("Current Cost: " + smashAP[10]); 
		            int changeData = userAP - smashAP[10];
		            remainingLabel.setText("AP Remaining: " + changeData);
		         }           
		      });
	      radSmash4.addItemListener(new ItemListener() {
		         public void itemStateChanged(ItemEvent e) {         
		            currentCostLabel.setText("Current Cost: " + smashAP[11]); 
		            int changeData = userAP - smashAP[11];
		            remainingLabel.setText("AP Remaining: " + changeData);
		         }           
		      });
	      radSmash3.addItemListener(new ItemListener() {
		         public void itemStateChanged(ItemEvent e) {         
		            currentCostLabel.setText("Current Cost: " + smashAP[12]); 
		            int changeData = userAP - smashAP[12];
		            remainingLabel.setText("AP Remaining: " + changeData);
		         }           
		      });
	      radSmash2.addItemListener(new ItemListener() {
		         public void itemStateChanged(ItemEvent e) {         
		            currentCostLabel.setText("Current Cost: " + smashAP[13]); 
		            int changeData = userAP - smashAP[13];
		            remainingLabel.setText("AP Remaining: " + changeData);
		         }           
		      });
	      radSmash1.addItemListener(new ItemListener() {
		         public void itemStateChanged(ItemEvent e) {         
		            currentCostLabel.setText("Current Cost: " + smashAP[14]);
		            int changeData = userAP - smashAP[14];
		            remainingLabel.setText("AP Remaining: " + changeData);
		         }           
		      });
	      radSmashDan1.addItemListener(new ItemListener() {
		         public void itemStateChanged(ItemEvent e) {         
		            currentCostLabel.setText("Current Cost: " + smashAP[15]); 
		            int changeData = userAP - smashAP[15];
		            remainingLabel.setText("AP Remaining: " + changeData);
		         }           
		      });
	      radSmashDan2.addItemListener(new ItemListener() {
		         public void itemStateChanged(ItemEvent e) {         
		            currentCostLabel.setText("Current Cost: " + smashAP[16]); 
		            int changeData = userAP - smashAP[16];
		            remainingLabel.setText("AP Remaining: " + changeData);
		         }           
		      });
	      radSmashDan3.addItemListener(new ItemListener() {
		         public void itemStateChanged(ItemEvent e) {         
		            currentCostLabel.setText("Current Cost: " + smashAP[17]); 
		            int changeData = userAP - smashAP[17];
		            remainingLabel.setText("AP Remaining: " + changeData);
		         }           
		      });
	      // end smash listeners
	      
	      
	      
	      //Group the radio buttons.
	      ButtonGroup group = new ButtonGroup();
	      
	      group.add(radHuman);
	      group.add(radElf);
	      group.add(radGiant);
	      
	      // smash group buttons
	      ButtonGroup smash = new ButtonGroup();
	      smash.add(radSmashF);
	      smash.add(radSmashE);
	      smash.add(radSmashD);
	      smash.add(radSmashC);
	      smash.add(radSmashB);
	      smash.add(radSmashA);
	      smash.add(radSmash9);
	      smash.add(radSmash8);
	      smash.add(radSmash7);
	      smash.add(radSmash6);
	      smash.add(radSmash5);
	      smash.add(radSmash4);
	      smash.add(radSmash3);
	      smash.add(radSmash2);
	      smash.add(radSmash1);
	      smash.add(radSmashDan1);
	      smash.add(radSmashDan2);
	      smash.add(radSmashDan3);

	      // add to control panel
	      controlPanel.add(radHuman);
	      controlPanel.add(radElf);
	      controlPanel.add(radGiant); 
	      
	      // add to skill panel
	      skillPanel.add(apLabel);
	      skillPanel.add(userText);
	      skillPanel.add(returnButton);
	      skillPanel.add(returnApLabel);
	      skillPanel.add(remainingLabel);
	      
	      skillPanel.add(radSmashF);
	      skillPanel.add(radSmashE);
	      skillPanel.add(radSmashD);
	      skillPanel.add(radSmashC);
	      skillPanel.add(radSmashB);
	      skillPanel.add(radSmashA);
	      skillPanel.add(radSmash9);
	      skillPanel.add(radSmash8);
	      skillPanel.add(radSmash7);
	      skillPanel.add(radSmash6);
	      skillPanel.add(radSmash5);
	      skillPanel.add(radSmash4);
	      skillPanel.add(radSmash3);
	      skillPanel.add(radSmash2);
	      skillPanel.add(radSmash1);
	      skillPanel.add(radSmashDan1);
	      skillPanel.add(radSmashDan2);
	      skillPanel.add(radSmashDan3);
	      
	      
	      controlPanel.add(currentCostLabel);

	      mainFrame.setVisible(true);  
	   }
	
	 // adding icons
	   private static ImageIcon createImageIcon(String path,
			      String description) {
			      java.net.URL imgURL = Controling.class.getResource(path);
			      
			      if (imgURL != null) {
			         return new ImageIcon(imgURL, description);
			      } else {            
			         System.err.println("Couldn't find file: " + path);
			         return null;
			      }
			   }
			   private void showSmashIcon(){
			      headerLabel.setText("Smash"); 
			      ImageIcon icon = createImageIcon("/mabi_app/Resources/Smash.png","Smash");

			      JLabel commentlabel = new JLabel("", icon,JLabel.CENTER);
			      controlPanel.add(commentlabel);
			      mainFrame.setVisible(true);  
			   }

}
