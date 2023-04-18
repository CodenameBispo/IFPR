/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.exemploswingmvc.view;

import java.awt.BorderLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JFrame;
import javax.swing.JMenu;
import javax.swing.JMenuBar;
import javax.swing.JMenuItem;

public class MenuPrincipal {
    
    public void criarMenu() {
        JFrame frame = new JFrame();
        JMenuBar menu = new JMenuBar();
        
        JMenu menuCadastro = new JMenu();
        menuCadastro.setText("Cadastro");
        
        JMenuItem menuCadastroUsuario = new JMenuItem();
        menuCadastroUsuario.setText("Usuário");
        
        menuCadastroUsuario.addActionListener(new ActionListener(){
            
            public void actionPerformed(ActionEvent e) {
                frame.getContentPane().removeAll();
                frame.getContentPane().add(menu, BorderLayout.NORTH);
                CadastroUsuario cadastroUsuarioView = new CadastroUsuario();
                cadastroUsuarioView.setFrame(frame);
                cadastroUsuarioView.criarCadastroUsuario();
            }
        }
        );
        
        menuCadastro.add(menuCadastroUsuario);
        menu.add(menuCadastro);
        
        JMenu menuProcura = new JMenu();
        menuProcura.setText("Procura");
        
        JMenuItem menuProcuraUsuario = new JMenuItem();
        menuProcuraUsuario.setText("Usuario");
        
        menuProcuraUsuario.addActionListener(new ActionListener(){
        
            public void actionPerformed(ActionEvent e) {
                frame.getContentPane().removeAll();
                frame.getContentPane().add(menu, BorderLayout.NORTH);
                ProcuraUsuario procuraUsuario = new ProcuraUsuario();
                procuraUsuario.setFrame(frame);
                procuraUsuario.criarProcuraUsuario();
            }
        }
        );
        
        frame.setLayout(new BorderLayout());
        frame.add(menu, BorderLayout.NORTH);
        frame.setSize(500,300);
        frame.setVisible(true);        
    }    
}
