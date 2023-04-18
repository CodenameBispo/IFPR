/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.exemploswingmvc.controller;

import com.mycompany.exemploswingmvc.dao.UsuarioDao;
import com.mycompany.exemploswingmvc.model.Usuario;
import java.util.List;

public class UsuarioController {
    
    public void insert(Usuario usuario) {
        UsuarioDao usuarioDao = new UsuarioDao();
        usuarioDao.insert(usuario);
        System.out.println("Usuário cadastrado com sucesso");
    }    
    
    public List<Usuario> findAll(){
        UsuarioDao usuarioDao = new UsuarioDao();
        return usuarioDao.findAll();
    }
}
