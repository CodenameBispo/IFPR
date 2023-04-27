/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.exemploswingmvc.controller;

import com.mycompany.exemploswingmvc.dao.UsuarioDao;
import com.mycompany.exemploswingmvc.model.Usuario;
import java.util.List;

public class UsuarioController {
    
    public void delete(int id) {
        UsuarioDao usuarioDao = new UsuarioDao();
        usuarioDao.delete(id);
        System.out.println("Usuário excluido com sucesso");
    }
    
    public void insert(Usuario usuario) {
        UsuarioDao usuarioDao = new UsuarioDao();
        usuarioDao.insert(usuario);
        System.out.println("Usuário cadastrado com sucesso");
    }

    public Usuario findById(int id ){
        UsuarioDao usuarioDao = new UsuarioDao();
        return usuarioDao.findById(id);
    }
    
    public List<Usuario> findByNomeOuCpf(String nome, String cpf){
        UsuarioDao usuarioDao = new UsuarioDao();
        return usuarioDao.findByNomeOuCpf(nome, cpf);
    }
    
    public List<Usuario> findAll(){
        UsuarioDao usuarioDao = new UsuarioDao();
        return usuarioDao.findAll();
    }
    
    public void update(Usuario usuario){
        UsuarioDao usuarioDao = new UsuarioDao();
        usuarioDao.update(usuario);
    }
}
