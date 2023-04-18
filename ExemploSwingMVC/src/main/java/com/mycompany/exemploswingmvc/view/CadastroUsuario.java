/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.exemploswingmvc.view;

import com.mycompany.exemploswingmvc.controller.TipoUsuarioController;
import com.mycompany.exemploswingmvc.controller.UsuarioController;
import com.mycompany.exemploswingmvc.model.TipoUsuario;
import com.mycompany.exemploswingmvc.model.Usuario;
import java.awt.BorderLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.text.ParseException;
import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JFormattedTextField;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;
import javax.swing.text.MaskFormatter;

public class CadastroUsuario {
    
    private JFrame frame;
    
    public JFrame getFrame() {
        return frame;
    }
    
    public void setFrame(JFrame frame) {
        this.frame = frame;
    }
    
    public void criarCadastroUsuario() {
        TipoUsuarioController tipoUsuarioController;
        tipoUsuarioController = new TipoUsuarioController();
        JPanel panelCadastroUsuario = new JPanel();
        
        JLabel labelId = new JLabel();
        labelId.setText("Id");
        labelId.setBounds(10,10,50,20);
        
        JTextField textId = new JTextField();
        textId.setText("Id");
        textId.setBounds(110,10,200,20);
        textId.setEnabled(false);
        
        JLabel labelNome = new JLabel();
        labelNome.setText("Nome");
        labelNome.setBounds(10,40,50,20);
        
        JTextField textNome = new JTextField();
        textNome.setText("Nome");
        textNome.setBounds(110,40,200,20);
        
        JLabel labelCpf = new JLabel();
        labelCpf.setText("CPF");
        labelCpf.setBounds(10,40,50,20);
        
        MaskFormatter mascaraCpf = null;
        try{
            mascaraCpf = new MaskFormatter("###.###.###-##");
            mascaraCpf.setPlaceholder("0");
        }
        catch(ParseException excp) {
            System.err.println("Erro na formatação: " +excp.getMessage());
            System.exit(-1);
        }
        
        JFormattedTextField jFormattedCpf = new JFormattedTextField(mascaraCpf);
        jFormattedCpf.setText("000.000.000-00");
        jFormattedCpf.setBounds(110,70,200,20);
        
        JLabel labelTipoUsuario = new JLabel();
        labelTipoUsuario.setText("Tipo Usuário");
        labelTipoUsuario.setBounds(10,100,100,20);
        
        JComboBox comboTipoUsuario = new JComboBox();
        
        for(TipoUsuario tipoUsuario: tipoUsuarioController.findAll()){
            comboTipoUsuario.addItem(tipoUsuario);            
        }
        
        comboTipoUsuario.setBounds(110, 100 ,200, 20);
        
        JButton buttonCadastrar = new JButton();
        buttonCadastrar.setText("Cadastrar");
        buttonCadastrar.setBounds(10, 200, 90, 25);
        
        buttonCadastrar.addActionListener(new ActionListener(){
        
            public void actionPerformed(ActionEvent e) {
                UsuarioController usuarioController;
                Usuario usuario;
                usuarioController = new UsuarioController();
                usuario = new Usuario();
            
                usuario.setCpf(jFormattedCpf.getText());
                usuario.setNome(textNome.getText());
                usuario.setTipoUsuario((TipoUsuario) comboTipoUsuario.getSelectedItem());
                usuarioController.insert(usuario);            
            }
        }
        );
        
        panelCadastroUsuario.setLayout(null);
        panelCadastroUsuario.add(labelId);
        panelCadastroUsuario.add(textId);
        
        panelCadastroUsuario.add(labelNome);
        panelCadastroUsuario.add(textNome);

        panelCadastroUsuario.add(labelCpf);
        panelCadastroUsuario.add(jFormattedCpf);
        
        panelCadastroUsuario.add(labelTipoUsuario);
        panelCadastroUsuario.add(comboTipoUsuario);

        panelCadastroUsuario.add(buttonCadastrar);

        frame.add(panelCadastroUsuario, BorderLayout.CENTER);
        frame.setVisible(true);
    }
}
